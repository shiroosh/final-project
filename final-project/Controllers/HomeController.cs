﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using final_project.Models;
using final_project.Data;

namespace final_project.Controllers
{
    public class HomeController : Controller
    {
        private readonly SweetShopContext _context;


        public HomeController(SweetShopContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.User.ToList());
        }
        public IActionResult Cart()
        {
            return View();
        }

        public IActionResult Shop()
        {
            ViewData["Message"] = "shop message";

            return View();
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
