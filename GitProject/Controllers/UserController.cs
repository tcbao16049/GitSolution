﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitProject.Controllers
{
    public class UserController : Controller
    {
        public ActionResult Register()
        {
            return View();
        }
    }
}