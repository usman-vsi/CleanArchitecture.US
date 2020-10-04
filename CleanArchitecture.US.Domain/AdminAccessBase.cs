/*
File generated by custome templates
Important: Do not modify this file. Edit the file AdminAccessBase.cs instead.
*/
#region using directives
using System;
#endregion

namespace CleanArchitecture.US.Domain
{
    public abstract class AdminAccessBase: EntityBase
    {
        #region Constructors
        protected AdminAccessBase()
        {
        }
        #endregion
        #region Properties
        private  Int32 _adminAccessId;
        public virtual  Int32  AdminAccessId
        {
           get
           {
               return _adminAccessId;
           }
           set
           {
               if ( _adminAccessId == value) return;
           _adminAccessId = value;
           EntityModified();
           }
           }
        private  Int32 _adminId;
        public virtual  Int32  AdminId
        {
           get
           {
               return _adminId;
           }
           set
           {
               if ( _adminId == value) return;
           _adminId = value;
           EntityModified();
           }
           }
        private  Int32 _createdBy;
        public virtual  Int32  CreatedBy
        {
           get
           {
               return _createdBy;
           }
           set
           {
               if ( _createdBy == value) return;
           _createdBy = value;
           EntityModified();
           }
           }
        private  string _firstName;
        public virtual  string  FirstName
        {
           get
           {
               return _firstName;
           }
           set
           {
               if ( _firstName == value) return;
           _firstName = value;
           EntityModified();
           }
           }
        private  Int32 _userId;
        public virtual  Int32  UserId
        {
           get
           {
               return _userId;
           }
           set
           {
               if ( _userId == value) return;
           _userId = value;
           EntityModified();
           }
           }
           #endregion
           public void AddValidationRules()
           {
           }
    }
}

