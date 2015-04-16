﻿using MomWorld.DataContexts;
using MomWorld.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MomWorld.Controllers
{
    public class SubscribersController : Controller
    {
        private SubscriberDb db = new SubscriberDb();

        // GET: Subscribers
        public ActionResult Index()
        {
            return View();
        }

        // GET: Subscribers/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        public JsonResult Create(Subscriber model)
        {
            if (ModelState.IsValid)
            {
                db.Entry(model).State = EntityState.Added;
                db.SaveChanges();

                SMSServices.Send(model.PhoneNumber, "Mom's World: Cam on ban da dang ky dich vu nhan tin cua chung toi!");
                return Json("Successfully");
            }

            return Json(null);
        }

        // GET: Subscribers/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Subscribers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Subscribers/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Subscribers/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
