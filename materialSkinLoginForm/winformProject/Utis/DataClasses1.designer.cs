﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace winformProject.Utis
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="smartParking")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InserttblAccount(tblAccount instance);
    partial void UpdatetblAccount(tblAccount instance);
    partial void DeletetblAccount(tblAccount instance);
    partial void InserttblCarPark(tblCarPark instance);
    partial void UpdatetblCarPark(tblCarPark instance);
    partial void DeletetblCarPark(tblCarPark instance);
    partial void InserttblCar(tblCar instance);
    partial void UpdatetblCar(tblCar instance);
    partial void DeletetblCar(tblCar instance);
    partial void InserttblHistory(tblHistory instance);
    partial void UpdatetblHistory(tblHistory instance);
    partial void DeletetblHistory(tblHistory instance);
    partial void InserttblUser(tblUser instance);
    partial void UpdatetblUser(tblUser instance);
    partial void DeletetblUser(tblUser instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::winformProject.Properties.Settings.Default.smartParkingConnectionString6, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<tblAccount> tblAccounts
		{
			get
			{
				return this.GetTable<tblAccount>();
			}
		}
		
		public System.Data.Linq.Table<tblCarPark> tblCarParks
		{
			get
			{
				return this.GetTable<tblCarPark>();
			}
		}
		
		public System.Data.Linq.Table<tblCar> tblCars
		{
			get
			{
				return this.GetTable<tblCar>();
			}
		}
		
		public System.Data.Linq.Table<tblHistory> tblHistories
		{
			get
			{
				return this.GetTable<tblHistory>();
			}
		}
		
		public System.Data.Linq.Table<tblUser> tblUsers
		{
			get
			{
				return this.GetTable<tblUser>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblAccount")]
	public partial class tblAccount : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _userID;
		
		private string _password;
		
		private string _roleName;
		
		private string _status;
		
		private EntityRef<tblUser> _tblUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(string value);
    partial void OnuserIDChanged();
    partial void OnpasswordChanging(string value);
    partial void OnpasswordChanged();
    partial void OnroleNameChanging(string value);
    partial void OnroleNameChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    #endregion
		
		public tblAccount()
		{
			this._tblUser = default(EntityRef<tblUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._tblUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_password", DbType="NVarChar(50)")]
		public string password
		{
			get
			{
				return this._password;
			}
			set
			{
				if ((this._password != value))
				{
					this.OnpasswordChanging(value);
					this.SendPropertyChanging();
					this._password = value;
					this.SendPropertyChanged("password");
					this.OnpasswordChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_roleName", DbType="NVarChar(50)")]
		public string roleName
		{
			get
			{
				return this._roleName;
			}
			set
			{
				if ((this._roleName != value))
				{
					this.OnroleNameChanging(value);
					this.SendPropertyChanging();
					this._roleName = value;
					this.SendPropertyChanged("roleName");
					this.OnroleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblAccount", Storage="_tblUser", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public tblUser tblUser
		{
			get
			{
				return this._tblUser.Entity;
			}
			set
			{
				tblUser previousValue = this._tblUser.Entity;
				if (((previousValue != value) 
							|| (this._tblUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUser.Entity = null;
						previousValue.tblAccount = null;
					}
					this._tblUser.Entity = value;
					if ((value != null))
					{
						value.tblAccount = this;
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(string);
					}
					this.SendPropertyChanged("tblUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCarPark")]
	public partial class tblCarPark : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _position;
		
		private System.Nullable<int> _carID;
		
		private string _note;
		
		private System.Nullable<System.DateTime> _timeIn;
		
		private EntityRef<tblCar> _tblCar;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnpositionChanging(string value);
    partial void OnpositionChanged();
    partial void OncarIDChanging(System.Nullable<int> value);
    partial void OncarIDChanged();
    partial void OnnoteChanging(string value);
    partial void OnnoteChanged();
    partial void OntimeInChanging(System.Nullable<System.DateTime> value);
    partial void OntimeInChanged();
    #endregion
		
		public tblCarPark()
		{
			this._tblCar = default(EntityRef<tblCar>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="NVarChar(255) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carID", DbType="Int")]
		public System.Nullable<int> carID
		{
			get
			{
				return this._carID;
			}
			set
			{
				if ((this._carID != value))
				{
					if (this._tblCar.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncarIDChanging(value);
					this.SendPropertyChanging();
					this._carID = value;
					this.SendPropertyChanged("carID");
					this.OncarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_note", DbType="NVarChar(MAX)")]
		public string note
		{
			get
			{
				return this._note;
			}
			set
			{
				if ((this._note != value))
				{
					this.OnnoteChanging(value);
					this.SendPropertyChanging();
					this._note = value;
					this.SendPropertyChanged("note");
					this.OnnoteChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeIn", DbType="DateTime")]
		public System.Nullable<System.DateTime> timeIn
		{
			get
			{
				return this._timeIn;
			}
			set
			{
				if ((this._timeIn != value))
				{
					this.OntimeInChanging(value);
					this.SendPropertyChanging();
					this._timeIn = value;
					this.SendPropertyChanged("timeIn");
					this.OntimeInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCar_tblCarPark", Storage="_tblCar", ThisKey="carID", OtherKey="carID", IsForeignKey=true)]
		public tblCar tblCar
		{
			get
			{
				return this._tblCar.Entity;
			}
			set
			{
				tblCar previousValue = this._tblCar.Entity;
				if (((previousValue != value) 
							|| (this._tblCar.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCar.Entity = null;
						previousValue.tblCarParks.Remove(this);
					}
					this._tblCar.Entity = value;
					if ((value != null))
					{
						value.tblCarParks.Add(this);
						this._carID = value.carID;
					}
					else
					{
						this._carID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblCar");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblCars")]
	public partial class tblCar : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _carID;
		
		private string _carName;
		
		private string _licensePlate;
		
		private string _userID;
		
		private string _status;
		
		private System.Data.Linq.Binary _nearestPhoto;
		
		private EntitySet<tblCarPark> _tblCarParks;
		
		private EntitySet<tblHistory> _tblHistories;
		
		private EntityRef<tblUser> _tblUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OncarIDChanging(int value);
    partial void OncarIDChanged();
    partial void OncarNameChanging(string value);
    partial void OncarNameChanged();
    partial void OnlicensePlateChanging(string value);
    partial void OnlicensePlateChanged();
    partial void OnuserIDChanging(string value);
    partial void OnuserIDChanged();
    partial void OnstatusChanging(string value);
    partial void OnstatusChanged();
    partial void OnnearestPhotoChanging(System.Data.Linq.Binary value);
    partial void OnnearestPhotoChanged();
    #endregion
		
		public tblCar()
		{
			this._tblCarParks = new EntitySet<tblCarPark>(new Action<tblCarPark>(this.attach_tblCarParks), new Action<tblCarPark>(this.detach_tblCarParks));
			this._tblHistories = new EntitySet<tblHistory>(new Action<tblHistory>(this.attach_tblHistories), new Action<tblHistory>(this.detach_tblHistories));
			this._tblUser = default(EntityRef<tblUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int carID
		{
			get
			{
				return this._carID;
			}
			set
			{
				if ((this._carID != value))
				{
					this.OncarIDChanging(value);
					this.SendPropertyChanging();
					this._carID = value;
					this.SendPropertyChanged("carID");
					this.OncarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carName", DbType="NVarChar(50)")]
		public string carName
		{
			get
			{
				return this._carName;
			}
			set
			{
				if ((this._carName != value))
				{
					this.OncarNameChanging(value);
					this.SendPropertyChanging();
					this._carName = value;
					this.SendPropertyChanged("carName");
					this.OncarNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_licensePlate", DbType="NVarChar(20)")]
		public string licensePlate
		{
			get
			{
				return this._licensePlate;
			}
			set
			{
				if ((this._licensePlate != value))
				{
					this.OnlicensePlateChanging(value);
					this.SendPropertyChanging();
					this._licensePlate = value;
					this.SendPropertyChanged("licensePlate");
					this.OnlicensePlateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._tblUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_status", DbType="NChar(10) NOT NULL", CanBeNull=false)]
		public string status
		{
			get
			{
				return this._status;
			}
			set
			{
				if ((this._status != value))
				{
					this.OnstatusChanging(value);
					this.SendPropertyChanging();
					this._status = value;
					this.SendPropertyChanged("status");
					this.OnstatusChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_nearestPhoto", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary nearestPhoto
		{
			get
			{
				return this._nearestPhoto;
			}
			set
			{
				if ((this._nearestPhoto != value))
				{
					this.OnnearestPhotoChanging(value);
					this.SendPropertyChanging();
					this._nearestPhoto = value;
					this.SendPropertyChanged("nearestPhoto");
					this.OnnearestPhotoChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCar_tblCarPark", Storage="_tblCarParks", ThisKey="carID", OtherKey="carID")]
		public EntitySet<tblCarPark> tblCarParks
		{
			get
			{
				return this._tblCarParks;
			}
			set
			{
				this._tblCarParks.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCar_tblHistory", Storage="_tblHistories", ThisKey="carID", OtherKey="carID")]
		public EntitySet<tblHistory> tblHistories
		{
			get
			{
				return this._tblHistories;
			}
			set
			{
				this._tblHistories.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblCar", Storage="_tblUser", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public tblUser tblUser
		{
			get
			{
				return this._tblUser.Entity;
			}
			set
			{
				tblUser previousValue = this._tblUser.Entity;
				if (((previousValue != value) 
							|| (this._tblUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUser.Entity = null;
						previousValue.tblCars.Remove(this);
					}
					this._tblUser.Entity = value;
					if ((value != null))
					{
						value.tblCars.Add(this);
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(string);
					}
					this.SendPropertyChanged("tblUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblCarParks(tblCarPark entity)
		{
			this.SendPropertyChanging();
			entity.tblCar = this;
		}
		
		private void detach_tblCarParks(tblCarPark entity)
		{
			this.SendPropertyChanging();
			entity.tblCar = null;
		}
		
		private void attach_tblHistories(tblHistory entity)
		{
			this.SendPropertyChanging();
			entity.tblCar = this;
		}
		
		private void detach_tblHistories(tblHistory entity)
		{
			this.SendPropertyChanging();
			entity.tblCar = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblHistorys")]
	public partial class tblHistory : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _historyID;
		
		private System.Nullable<int> _carID;
		
		private System.Nullable<System.DateTime> _timeIn;
		
		private System.Nullable<System.DateTime> _timeOut;
		
		private string _position;
		
		private System.Nullable<double> _money;
		
		private string _keyCode;
		
		private string _userID;
		
		private EntityRef<tblCar> _tblCar;
		
		private EntityRef<tblUser> _tblUser;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnhistoryIDChanging(int value);
    partial void OnhistoryIDChanged();
    partial void OncarIDChanging(System.Nullable<int> value);
    partial void OncarIDChanged();
    partial void OntimeInChanging(System.Nullable<System.DateTime> value);
    partial void OntimeInChanged();
    partial void OntimeOutChanging(System.Nullable<System.DateTime> value);
    partial void OntimeOutChanged();
    partial void OnpositionChanging(string value);
    partial void OnpositionChanged();
    partial void OnmoneyChanging(System.Nullable<double> value);
    partial void OnmoneyChanged();
    partial void OnkeyCodeChanging(string value);
    partial void OnkeyCodeChanged();
    partial void OnuserIDChanging(string value);
    partial void OnuserIDChanged();
    #endregion
		
		public tblHistory()
		{
			this._tblCar = default(EntityRef<tblCar>);
			this._tblUser = default(EntityRef<tblUser>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_historyID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int historyID
		{
			get
			{
				return this._historyID;
			}
			set
			{
				if ((this._historyID != value))
				{
					this.OnhistoryIDChanging(value);
					this.SendPropertyChanging();
					this._historyID = value;
					this.SendPropertyChanged("historyID");
					this.OnhistoryIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_carID", DbType="Int")]
		public System.Nullable<int> carID
		{
			get
			{
				return this._carID;
			}
			set
			{
				if ((this._carID != value))
				{
					if (this._tblCar.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OncarIDChanging(value);
					this.SendPropertyChanging();
					this._carID = value;
					this.SendPropertyChanged("carID");
					this.OncarIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeIn", DbType="DateTime")]
		public System.Nullable<System.DateTime> timeIn
		{
			get
			{
				return this._timeIn;
			}
			set
			{
				if ((this._timeIn != value))
				{
					this.OntimeInChanging(value);
					this.SendPropertyChanging();
					this._timeIn = value;
					this.SendPropertyChanged("timeIn");
					this.OntimeInChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_timeOut", DbType="DateTime")]
		public System.Nullable<System.DateTime> timeOut
		{
			get
			{
				return this._timeOut;
			}
			set
			{
				if ((this._timeOut != value))
				{
					this.OntimeOutChanging(value);
					this.SendPropertyChanging();
					this._timeOut = value;
					this.SendPropertyChanged("timeOut");
					this.OntimeOutChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_position", DbType="NVarChar(50)")]
		public string position
		{
			get
			{
				return this._position;
			}
			set
			{
				if ((this._position != value))
				{
					this.OnpositionChanging(value);
					this.SendPropertyChanging();
					this._position = value;
					this.SendPropertyChanged("position");
					this.OnpositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_money", DbType="Float")]
		public System.Nullable<double> money
		{
			get
			{
				return this._money;
			}
			set
			{
				if ((this._money != value))
				{
					this.OnmoneyChanging(value);
					this.SendPropertyChanging();
					this._money = value;
					this.SendPropertyChanged("money");
					this.OnmoneyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_keyCode", DbType="NVarChar(50)")]
		public string keyCode
		{
			get
			{
				return this._keyCode;
			}
			set
			{
				if ((this._keyCode != value))
				{
					this.OnkeyCodeChanging(value);
					this.SendPropertyChanging();
					this._keyCode = value;
					this.SendPropertyChanged("keyCode");
					this.OnkeyCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					if (this._tblUser.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblCar_tblHistory", Storage="_tblCar", ThisKey="carID", OtherKey="carID", IsForeignKey=true)]
		public tblCar tblCar
		{
			get
			{
				return this._tblCar.Entity;
			}
			set
			{
				tblCar previousValue = this._tblCar.Entity;
				if (((previousValue != value) 
							|| (this._tblCar.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblCar.Entity = null;
						previousValue.tblHistories.Remove(this);
					}
					this._tblCar.Entity = value;
					if ((value != null))
					{
						value.tblHistories.Add(this);
						this._carID = value.carID;
					}
					else
					{
						this._carID = default(Nullable<int>);
					}
					this.SendPropertyChanged("tblCar");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblHistory", Storage="_tblUser", ThisKey="userID", OtherKey="userID", IsForeignKey=true)]
		public tblUser tblUser
		{
			get
			{
				return this._tblUser.Entity;
			}
			set
			{
				tblUser previousValue = this._tblUser.Entity;
				if (((previousValue != value) 
							|| (this._tblUser.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblUser.Entity = null;
						previousValue.tblHistories.Remove(this);
					}
					this._tblUser.Entity = value;
					if ((value != null))
					{
						value.tblHistories.Add(this);
						this._userID = value.userID;
					}
					else
					{
						this._userID = default(string);
					}
					this.SendPropertyChanged("tblUser");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.tblUsers")]
	public partial class tblUser : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _userID;
		
		private string _firstName;
		
		private string _lastName;
		
		private string _mail;
		
		private string _phoneNumber;
		
		private System.Data.Linq.Binary _image;
		
		private EntityRef<tblAccount> _tblAccount;
		
		private EntitySet<tblCar> _tblCars;
		
		private EntitySet<tblHistory> _tblHistories;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnuserIDChanging(string value);
    partial void OnuserIDChanged();
    partial void OnfirstNameChanging(string value);
    partial void OnfirstNameChanged();
    partial void OnlastNameChanging(string value);
    partial void OnlastNameChanged();
    partial void OnmailChanging(string value);
    partial void OnmailChanged();
    partial void OnphoneNumberChanging(string value);
    partial void OnphoneNumberChanged();
    partial void OnimageChanging(System.Data.Linq.Binary value);
    partial void OnimageChanged();
    #endregion
		
		public tblUser()
		{
			this._tblAccount = default(EntityRef<tblAccount>);
			this._tblCars = new EntitySet<tblCar>(new Action<tblCar>(this.attach_tblCars), new Action<tblCar>(this.detach_tblCars));
			this._tblHistories = new EntitySet<tblHistory>(new Action<tblHistory>(this.attach_tblHistories), new Action<tblHistory>(this.detach_tblHistories));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_userID", DbType="NVarChar(50) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string userID
		{
			get
			{
				return this._userID;
			}
			set
			{
				if ((this._userID != value))
				{
					this.OnuserIDChanging(value);
					this.SendPropertyChanging();
					this._userID = value;
					this.SendPropertyChanged("userID");
					this.OnuserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_firstName", DbType="NVarChar(50)")]
		public string firstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				if ((this._firstName != value))
				{
					this.OnfirstNameChanging(value);
					this.SendPropertyChanging();
					this._firstName = value;
					this.SendPropertyChanged("firstName");
					this.OnfirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_lastName", DbType="NVarChar(50)")]
		public string lastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				if ((this._lastName != value))
				{
					this.OnlastNameChanging(value);
					this.SendPropertyChanging();
					this._lastName = value;
					this.SendPropertyChanged("lastName");
					this.OnlastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_mail", DbType="NVarChar(70)")]
		public string mail
		{
			get
			{
				return this._mail;
			}
			set
			{
				if ((this._mail != value))
				{
					this.OnmailChanging(value);
					this.SendPropertyChanging();
					this._mail = value;
					this.SendPropertyChanged("mail");
					this.OnmailChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_phoneNumber", DbType="NVarChar(11)")]
		public string phoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				if ((this._phoneNumber != value))
				{
					this.OnphoneNumberChanging(value);
					this.SendPropertyChanging();
					this._phoneNumber = value;
					this.SendPropertyChanged("phoneNumber");
					this.OnphoneNumberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_image", DbType="VarBinary(MAX)", UpdateCheck=UpdateCheck.Never)]
		public System.Data.Linq.Binary image
		{
			get
			{
				return this._image;
			}
			set
			{
				if ((this._image != value))
				{
					this.OnimageChanging(value);
					this.SendPropertyChanging();
					this._image = value;
					this.SendPropertyChanged("image");
					this.OnimageChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblAccount", Storage="_tblAccount", ThisKey="userID", OtherKey="userID", IsUnique=true, IsForeignKey=false)]
		public tblAccount tblAccount
		{
			get
			{
				return this._tblAccount.Entity;
			}
			set
			{
				tblAccount previousValue = this._tblAccount.Entity;
				if (((previousValue != value) 
							|| (this._tblAccount.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._tblAccount.Entity = null;
						previousValue.tblUser = null;
					}
					this._tblAccount.Entity = value;
					if ((value != null))
					{
						value.tblUser = this;
					}
					this.SendPropertyChanged("tblAccount");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblCar", Storage="_tblCars", ThisKey="userID", OtherKey="userID")]
		public EntitySet<tblCar> tblCars
		{
			get
			{
				return this._tblCars;
			}
			set
			{
				this._tblCars.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="tblUser_tblHistory", Storage="_tblHistories", ThisKey="userID", OtherKey="userID")]
		public EntitySet<tblHistory> tblHistories
		{
			get
			{
				return this._tblHistories;
			}
			set
			{
				this._tblHistories.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_tblCars(tblCar entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = this;
		}
		
		private void detach_tblCars(tblCar entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = null;
		}
		
		private void attach_tblHistories(tblHistory entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = this;
		}
		
		private void detach_tblHistories(tblHistory entity)
		{
			this.SendPropertyChanging();
			entity.tblUser = null;
		}
	}
}
#pragma warning restore 1591
