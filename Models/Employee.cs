﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManager.ApiClient.Models
{
    public class Employee
    {
        [Required(ErrorMessage = "Employee ID is required")]
        [Display(Name = "Employee ID")]
        public int EmployeeID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name is required")]
        [StringLength(10,ErrorMessage = "First Name must be less than 10 characters")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name is required")]
        [StringLength(20, ErrorMessage = "Last Name must be less than 20 characters")]
        public string LastName { get; set; }


        [Display(Name = "Title")]
        [Required(ErrorMessage = "Title is required")]
        [StringLength(30, ErrorMessage = "Title must be less than 30 characters")]
        public string Title { get; set; }


        [Display(Name = "Birth Date")]
        [Required(ErrorMessage = "Birth Date is required")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Hire Date")]
        [Required(ErrorMessage = "Hire Date is required")]
        public DateTime HireDate { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Country is required")]
        [StringLength(15, ErrorMessage = "Country must be less than 15 characters")]
        public string Country { get; set; }

        [Display(Name = "Notes")]
        [StringLength(500, ErrorMessage = "Notes must be less than 500 characters")]
        public string Notes { get; set; }
    }
}
