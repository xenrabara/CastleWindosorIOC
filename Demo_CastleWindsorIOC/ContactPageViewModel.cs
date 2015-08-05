using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CastleWindsorIOC
{
    public class ContactPageViewModel
    {
        public ContactPageViewModel()
        {
            Contacts = new ObservableCollection<Contact>()
            {
                new Contact(1)
                {
                    FirstName = "Person",
                    LastName = "1"
                },
                new Contact(2)
                {
                    FirstName = "Person",
                    LastName = "2"
                },
                new Contact(3)
                {
                    FirstName = "Person",
                    LastName = "3"
                },
                new Contact(4)
                {
                    FirstName = "Person",
                    LastName = "4"
                }
            };
        }

        public ObservableCollection<Contact> Contacts { get; set; }

        public void AddContact()
        {
            if (Contacts == null)
            {
                Contacts = new ObservableCollection<Contact>();
            }

            var nextId = Contacts.Select(c => c.Id).Max() + 1;
            Contacts.Add(new Contact(nextId)
            {
                FirstName = "Person",
                LastName = nextId.ToString()
            });
        }
    }

    public class Contact
    {
        public Contact(int id)
        {
            Id = id;
        }
        public int Id { get; private set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }
        
    }
}
