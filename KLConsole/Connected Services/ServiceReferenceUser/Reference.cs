﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KLConsole.ServiceReferenceUser {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceUser.IUsers")]
    public interface IUsers {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/AddNewUser", ReplyAction="http://tempuri.org/IUsers/AddNewUserResponse")]
        bool AddNewUser(string mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/AddNewUser", ReplyAction="http://tempuri.org/IUsers/AddNewUserResponse")]
        System.Threading.Tasks.Task<bool> AddNewUserAsync(string mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/AddUserAdress", ReplyAction="http://tempuri.org/IUsers/AddUserAdressResponse")]
        bool AddUserAdress(string ip, string userName, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/AddUserAdress", ReplyAction="http://tempuri.org/IUsers/AddUserAdressResponse")]
        System.Threading.Tasks.Task<bool> AddUserAdressAsync(string ip, string userName, int userId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/GetUserId", ReplyAction="http://tempuri.org/IUsers/GetUserIdResponse")]
        int GetUserId(string mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/GetUserId", ReplyAction="http://tempuri.org/IUsers/GetUserIdResponse")]
        System.Threading.Tasks.Task<int> GetUserIdAsync(string mac);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/GetAllUsersMac", ReplyAction="http://tempuri.org/IUsers/GetAllUsersMacResponse")]
        string[] GetAllUsersMac();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUsers/GetAllUsersMac", ReplyAction="http://tempuri.org/IUsers/GetAllUsersMacResponse")]
        System.Threading.Tasks.Task<string[]> GetAllUsersMacAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IUsersChannel : KLConsole.ServiceReferenceUser.IUsers, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class UsersClient : System.ServiceModel.ClientBase<KLConsole.ServiceReferenceUser.IUsers>, KLConsole.ServiceReferenceUser.IUsers {
        
        public UsersClient() {
        }
        
        public UsersClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public UsersClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsersClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public UsersClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddNewUser(string mac) {
            return base.Channel.AddNewUser(mac);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewUserAsync(string mac) {
            return base.Channel.AddNewUserAsync(mac);
        }
        
        public bool AddUserAdress(string ip, string userName, int userId) {
            return base.Channel.AddUserAdress(ip, userName, userId);
        }
        
        public System.Threading.Tasks.Task<bool> AddUserAdressAsync(string ip, string userName, int userId) {
            return base.Channel.AddUserAdressAsync(ip, userName, userId);
        }
        
        public int GetUserId(string mac) {
            return base.Channel.GetUserId(mac);
        }
        
        public System.Threading.Tasks.Task<int> GetUserIdAsync(string mac) {
            return base.Channel.GetUserIdAsync(mac);
        }
        
        public string[] GetAllUsersMac() {
            return base.Channel.GetAllUsersMac();
        }
        
        public System.Threading.Tasks.Task<string[]> GetAllUsersMacAsync() {
            return base.Channel.GetAllUsersMacAsync();
        }
    }
}