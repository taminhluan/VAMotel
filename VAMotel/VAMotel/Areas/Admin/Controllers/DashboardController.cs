﻿using Model.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VAMotel.Controllers;

namespace VAMotel.Areas.Admin.Controllers
{
    public class DashboardController : AdminController
    {
        
        // GET: Admin/Dashboard
        public ActionResult Index()
        {
            return View();
        }
    }
}