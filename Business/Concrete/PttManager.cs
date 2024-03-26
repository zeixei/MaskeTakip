using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {

        private IApplicantService _applicantService; //fieldlar class icinde alt cizgiyle

        public PttManager(IApplicantService applicantService) //constructor new yapildiginda calisir
        {
            _applicantService = applicantService;
        }
        public void GiveMask(Person person)
        { 
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "icin maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}
