﻿using Microsoft.AspNetCore.Mvc;

namespace SefaYedekSan.WebApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
