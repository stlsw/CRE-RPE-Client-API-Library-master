﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.269
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace pcAmerica.DesktopPOS.API.Client.MenuService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Context", Namespace="http://pcAmerica.com/DesktopPOS/General/DataContracts/2009/10/26")]
    [System.SerializableAttribute()]
    public partial class Context : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CashierIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StationIDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StoreIDField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CashierID {
            get {
                return this.CashierIDField;
            }
            set {
                if ((object.ReferenceEquals(this.CashierIDField, value) != true)) {
                    this.CashierIDField = value;
                    this.RaisePropertyChanged("CashierID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StationID {
            get {
                return this.StationIDField;
            }
            set {
                if ((object.ReferenceEquals(this.StationIDField, value) != true)) {
                    this.StationIDField = value;
                    this.RaisePropertyChanged("StationID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StoreID {
            get {
                return this.StoreIDField;
            }
            set {
                if ((object.ReferenceEquals(this.StoreIDField, value) != true)) {
                    this.StoreIDField = value;
                    this.RaisePropertyChanged("StoreID");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Menu", Namespace="http://pcAmerica.com/DesktopPOS/MenuService/DataContracts/2009/10/26")]
    [System.SerializableAttribute()]
    public partial class Menu : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<pcAmerica.DesktopPOS.API.Client.MenuService.Button> DepartmentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime ExpirationDateTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<pcAmerica.DesktopPOS.API.Client.MenuService.Button> Departments {
            get {
                return this.DepartmentsField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartmentsField, value) != true)) {
                    this.DepartmentsField = value;
                    this.RaisePropertyChanged("Departments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime ExpirationDateTime {
            get {
                return this.ExpirationDateTimeField;
            }
            set {
                if ((this.ExpirationDateTimeField.Equals(value) != true)) {
                    this.ExpirationDateTimeField = value;
                    this.RaisePropertyChanged("ExpirationDateTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Button", Namespace="http://pcAmerica.com/DesktopPOS/MenuService/DataContracts/2009/10/26")]
    [System.SerializableAttribute()]
    public partial class Button : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string BackColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Collections.Generic.List<pcAmerica.DesktopPOS.API.Client.MenuService.Button> ChildButtonsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ForeColorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TextField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool VisibleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string BackColor {
            get {
                return this.BackColorField;
            }
            set {
                if ((object.ReferenceEquals(this.BackColorField, value) != true)) {
                    this.BackColorField = value;
                    this.RaisePropertyChanged("BackColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<pcAmerica.DesktopPOS.API.Client.MenuService.Button> ChildButtons {
            get {
                return this.ChildButtonsField;
            }
            set {
                if ((object.ReferenceEquals(this.ChildButtonsField, value) != true)) {
                    this.ChildButtonsField = value;
                    this.RaisePropertyChanged("ChildButtons");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ForeColor {
            get {
                return this.ForeColorField;
            }
            set {
                if ((object.ReferenceEquals(this.ForeColorField, value) != true)) {
                    this.ForeColorField = value;
                    this.RaisePropertyChanged("ForeColor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ID {
            get {
                return this.IDField;
            }
            set {
                if ((object.ReferenceEquals(this.IDField, value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Text {
            get {
                return this.TextField;
            }
            set {
                if ((object.ReferenceEquals(this.TextField, value) != true)) {
                    this.TextField = value;
                    this.RaisePropertyChanged("Text");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool Visible {
            get {
                return this.VisibleField;
            }
            set {
                if ((this.VisibleField.Equals(value) != true)) {
                    this.VisibleField = value;
                    this.RaisePropertyChanged("Visible");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://pcAmerica.com/DesktopPOS/MenuService/ServiceContracts/2011/05/13", ConfigurationName="MenuService.MenuService")]
    public interface MenuService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://pcAmerica.com/DesktopPOS/MenuService/ServiceContracts/2011/05/13/MenuServi" +
            "ce/GetCurrentMenu", ReplyAction="http://pcAmerica.com/DesktopPOS/MenuService/ServiceContracts/2011/05/13/MenuServi" +
            "ce/GetCurrentMenuResponse")]
        pcAmerica.DesktopPOS.API.Client.MenuService.Menu GetCurrentMenu(pcAmerica.DesktopPOS.API.Client.MenuService.Context context);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MenuServiceChannel : pcAmerica.DesktopPOS.API.Client.MenuService.MenuService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MenuServiceClient : System.ServiceModel.ClientBase<pcAmerica.DesktopPOS.API.Client.MenuService.MenuService>, pcAmerica.DesktopPOS.API.Client.MenuService.MenuService {
        
        public MenuServiceClient() {
        }
        
        public MenuServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MenuServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MenuServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public pcAmerica.DesktopPOS.API.Client.MenuService.Menu GetCurrentMenu(pcAmerica.DesktopPOS.API.Client.MenuService.Context context) {
            return base.Channel.GetCurrentMenu(context);
        }
    }
}