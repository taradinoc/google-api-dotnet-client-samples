//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.5446
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Google.Apis.Audit.v1.Data {
    using System;
    using System.Collections;
    using System.Collections.Generic;
    
    
    public class Activities : Google.Apis.Requests.IDirectResponseSchema {
        
        private IList<Activity> items;
        
        private string kind;
        
        private string next;
        
        private Google.Apis.Requests.RequestError error;
        
        private string eTag;
        
        /// <summary>Each record in read response.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("items")]
        public virtual IList<Activity> Items {
            get {
                return this.items;
            }
            set {
                this.items = value;
            }
        }
        
        /// <summary>Kind of list response this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Next page URL.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("next")]
        public virtual string Next {
            get {
                return this.next;
            }
            set {
                this.next = value;
            }
        }
        
        [Newtonsoft.Json.JsonPropertyAttribute("error")]
        public virtual Google.Apis.Requests.RequestError Error {
            get {
                return this.error;
            }
            set {
                this.error = value;
            }
        }
        
        public virtual string ETag {
            get {
                return this.eTag;
            }
            set {
                this.eTag = value;
            }
        }
    }
    
    public class Activity {
        
        private Activity.ActorData actor;
        
        private IList<Activity.EventsData> events;
        
        private Activity.IdData id;
        
        private string ipAddress;
        
        private string kind;
        
        private string ownerDomain;
        
        /// <summary>User doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("actor")]
        public virtual Activity.ActorData Actor {
            get {
                return this.actor;
            }
            set {
                this.actor = value;
            }
        }
        
        /// <summary>Activity events.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("events")]
        public virtual IList<Activity.EventsData> Events {
            get {
                return this.events;
            }
            set {
                this.events = value;
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("id")]
        public virtual Activity.IdData Id {
            get {
                return this.id;
            }
            set {
                this.id = value;
            }
        }
        
        /// <summary>IP Address of the user doing the action.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ipAddress")]
        public virtual string IpAddress {
            get {
                return this.ipAddress;
            }
            set {
                this.ipAddress = value;
            }
        }
        
        /// <summary>Kind of resource this is.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("kind")]
        public virtual string Kind {
            get {
                return this.kind;
            }
            set {
                this.kind = value;
            }
        }
        
        /// <summary>Domain of source customer.</summary>
        [Newtonsoft.Json.JsonPropertyAttribute("ownerDomain")]
        public virtual string OwnerDomain {
            get {
                return this.ownerDomain;
            }
            set {
                this.ownerDomain = value;
            }
        }
        
        /// <summary>User doing the action.</summary>
        public class ActorData {
            
            private string applicationId;
            
            private string callerType;
            
            private string email;
            
            private string key;
            
            /// <summary>ID of application which interacted on behalf of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this.applicationId;
                }
                set {
                    this.applicationId = value;
                }
            }
            
            /// <summary>User or OAuth 2LO request.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("callerType")]
            public virtual string CallerType {
                get {
                    return this.callerType;
                }
                set {
                    this.callerType = value;
                }
            }
            
            /// <summary>Email address of the user.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("email")]
            public virtual string Email {
                get {
                    return this.email;
                }
                set {
                    this.email = value;
                }
            }
            
            /// <summary>For OAuth 2LO API requests, consumer_key of the requestor.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("key")]
            public virtual string Key {
                get {
                    return this.key;
                }
                set {
                    this.key = value;
                }
            }
        }
        
        public class EventsData {
            
            private string eventType;
            
            private string name;
            
            private IList<EventsData.ParametersData> parameters;
            
            /// <summary>Type of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("eventType")]
            public virtual string EventType {
                get {
                    return this.eventType;
                }
                set {
                    this.eventType = value;
                }
            }
            
            /// <summary>Name of event.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("name")]
            public virtual string Name {
                get {
                    return this.name;
                }
                set {
                    this.name = value;
                }
            }
            
            /// <summary>Event parameters.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("parameters")]
            public virtual IList<EventsData.ParametersData> Parameters {
                get {
                    return this.parameters;
                }
                set {
                    this.parameters = value;
                }
            }
            
            public class ParametersData {
                
                private string name;
                
                private string value;
                
                /// <summary>Name of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("name")]
                public virtual string Name {
                    get {
                        return this.name;
                    }
                    set {
                        this.name = value;
                    }
                }
                
                /// <summary>Value of the parameter.</summary>
                [Newtonsoft.Json.JsonPropertyAttribute("value")]
                public virtual string Value {
                    get {
                        return this.value;
                    }
                    set {
                        this.value = value;
                    }
                }
            }
        }
        
        /// <summary>Unique identifier for each activity record.</summary>
        public class IdData {
            
            private string applicationId;
            
            private string customerId;
            
            private string time;
            
            private string uniqQualifier;
            
            /// <summary>Application ID of the source application.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("applicationId")]
            public virtual string ApplicationId {
                get {
                    return this.applicationId;
                }
                set {
                    this.applicationId = value;
                }
            }
            
            /// <summary>Obfuscated customer ID of the source customer.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this.customerId;
                }
                set {
                    this.customerId = value;
                }
            }
            
            /// <summary>Time of occurrence of the activity.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("time")]
            public virtual string Time {
                get {
                    return this.time;
                }
                set {
                    this.time = value;
                }
            }
            
            /// <summary>Unique qualifier if multiple events have the same time.</summary>
            [Newtonsoft.Json.JsonPropertyAttribute("uniqQualifier")]
            public virtual string UniqQualifier {
                get {
                    return this.uniqQualifier;
                }
                set {
                    this.uniqQualifier = value;
                }
            }
        }
    }
}
namespace Google.Apis.Audit.v1 {
    using System;
    using System.IO;
    using System.Collections.Generic;
    using Google.Apis;
    using Google.Apis.Discovery;
    
    
    public class AuditService : Google.Apis.Discovery.IRequestProvider {
        
        private Google.Apis.Discovery.IService genericService;
        
        private Google.Apis.Authentication.IAuthenticator authenticator;
        
        private const string DiscoveryDocument = "{\"kind\":\"discovery#restDescription\",\"id\":\"audit:v1\",\"name\":\"audit\",\"version\":\"v1\"" +
            ",\"title\":\"Enterprise Audit API\",\"description\":\"Lets you access user activities i" +
            "n your enterprise made through various applications.\",\"icons\":{\"x16\":\"http://www" +
            ".google.com/images/icons/product/search-16.gif\",\"x32\":\"http://www.google.com/ima" +
            "ges/icons/product/search-32.gif\"},\"labels\":[\"labs\"],\"protocol\":\"rest\",\"basePath\"" +
            ":\"/apps/reporting/audit/v1/\",\"parameters\":{\"alt\":{\"type\":\"string\",\"description\":" +
            "\"Data format for the response.\",\"default\":\"json\",\"enum\":[\"atom\",\"json\"],\"enumDes" +
            "criptions\":[\"Responses with Content-Type of application/atom+xml\",\"Responses wit" +
            "h Content-Type of application/json\"],\"location\":\"query\"},\"fields\":{\"type\":\"strin" +
            "g\",\"description\":\"Selector specifying which fields to include in a partial respo" +
            "nse.\",\"location\":\"query\"},\"key\":{\"type\":\"string\",\"description\":\"API key. Your AP" +
            "I key identifies your project and provides you with API access, quota, and repor" +
            "ts. Required unless you provide an OAuth 2.0 token.\",\"location\":\"query\"},\"oauth_" +
            "token\":{\"type\":\"string\",\"description\":\"OAuth 2.0 token for the current user.\",\"l" +
            "ocation\":\"query\"},\"prettyPrint\":{\"type\":\"boolean\",\"description\":\"Returns respons" +
            "e with indentations and line breaks.\",\"default\":\"true\",\"location\":\"query\"},\"user" +
            "Ip\":{\"type\":\"string\",\"description\":\"IP address of the site where the request ori" +
            "ginates. Use this if you want to enforce per-user limits.\",\"location\":\"query\"}}," +
            "\"schemas\":{\"Activities\":{\"id\":\"Activities\",\"type\":\"object\",\"properties\":{\"items\"" +
            ":{\"type\":\"array\",\"description\":\"Each record in read response.\",\"items\":{\"$ref\":\"" +
            "Activity\"}},\"kind\":{\"type\":\"string\",\"description\":\"Kind of list response this is" +
            ".\",\"default\":\"audit#activities\"},\"next\":{\"type\":\"string\",\"description\":\"Next pag" +
            "e URL.\"}}},\"Activity\":{\"id\":\"Activity\",\"type\":\"object\",\"properties\":{\"actor\":{\"t" +
            "ype\":\"object\",\"description\":\"User doing the action.\",\"properties\":{\"applicationI" +
            "d\":{\"type\":\"string\",\"description\":\"ID of application which interacted on behalf " +
            "of the user.\",\"format\":\"int64\"},\"callerType\":{\"type\":\"string\",\"description\":\"Use" +
            "r or OAuth 2LO request.\"},\"email\":{\"type\":\"string\",\"description\":\"Email address " +
            "of the user.\"},\"key\":{\"type\":\"string\",\"description\":\"For OAuth 2LO API requests," +
            " consumer_key of the requestor.\"}}},\"events\":{\"type\":\"array\",\"description\":\"Acti" +
            "vity events.\",\"items\":{\"type\":\"object\",\"properties\":{\"eventType\":{\"type\":\"string" +
            "\",\"description\":\"Type of event.\"},\"name\":{\"type\":\"string\",\"description\":\"Name of" +
            " event.\"},\"parameters\":{\"type\":\"array\",\"description\":\"Event parameters.\",\"items\"" +
            ":{\"type\":\"object\",\"properties\":{\"name\":{\"type\":\"string\",\"description\":\"Name of t" +
            "he parameter.\"},\"value\":{\"type\":\"string\",\"description\":\"Value of the parameter.\"" +
            "}}}}}}},\"id\":{\"type\":\"object\",\"description\":\"Unique identifier for each activity" +
            " record.\",\"properties\":{\"applicationId\":{\"type\":\"string\",\"description\":\"Applicat" +
            "ion ID of the source application.\",\"format\":\"int64\"},\"customerId\":{\"type\":\"strin" +
            "g\",\"description\":\"Obfuscated customer ID of the source customer.\"},\"time\":{\"type" +
            "\":\"string\",\"description\":\"Time of occurrence of the activity.\",\"format\":\"date-ti" +
            "me\"},\"uniqQualifier\":{\"type\":\"string\",\"description\":\"Unique qualifier if multipl" +
            "e events have the same time.\",\"format\":\"int64\"}}},\"ipAddress\":{\"type\":\"string\",\"" +
            "description\":\"IP Address of the user doing the action.\"},\"kind\":{\"type\":\"string\"" +
            ",\"description\":\"Kind of resource this is.\",\"default\":\"audit#activity\"},\"ownerDom" +
            "ain\":{\"type\":\"string\",\"description\":\"Domain of source customer.\"}}}},\"resources\"" +
            ":{\"activities\":{\"methods\":{\"list\":{\"id\":\"audit.activities.list\",\"path\":\"{custome" +
            "rId}/{applicationId}\",\"httpMethod\":\"GET\",\"description\":\"Retrieves a list of acti" +
            "vities for a specific customer and application.\",\"parameters\":{\"actorApplication" +
            "Id\":{\"type\":\"integer\",\"description\":\"Application ID of the application which int" +
            "eracted on behalf of the user while performing the event.\",\"minimum\":\"-922337203" +
            "6854775808\",\"maximum\":\"9223372036854775807\",\"location\":\"query\"},\"actorEmail\":{\"t" +
            "ype\":\"string\",\"description\":\"Email address of the user who performed the action." +
            "\",\"location\":\"query\"},\"applicationId\":{\"type\":\"integer\",\"description\":\"Applicati" +
            "on ID of the application on which the event was performed.\",\"required\":true,\"min" +
            "imum\":\"-9223372036854775808\",\"maximum\":\"9223372036854775807\",\"location\":\"path\"}," +
            "\"caller\":{\"type\":\"string\",\"description\":\"Type of the caller.\",\"enum\":[\"applicati" +
            "on_owner\",\"customer\"],\"enumDescriptions\":[\"Caller is an application owner.\",\"Cal" +
            "ler is a customer.\"],\"location\":\"query\"},\"continuationToken\":{\"type\":\"string\",\"d" +
            "escription\":\"Next page URL.\",\"location\":\"query\"},\"customerId\":{\"type\":\"string\",\"" +
            "description\":\"Represents the customer who is the owner of target object on which" +
            " action was performed.\",\"required\":true,\"pattern\":\"C.+\",\"location\":\"path\"},\"endT" +
            "ime\":{\"type\":\"string\",\"description\":\"Return events which occured at or before th" +
            "is time.\",\"location\":\"query\"},\"eventName\":{\"type\":\"string\",\"description\":\"Name o" +
            "f the event being queried.\",\"location\":\"query\"},\"maxResults\":{\"type\":\"integer\",\"" +
            "description\":\"Number of activity records to be shown in each page.\",\"minimum\":\"1" +
            "\",\"maximum\":\"1000\",\"location\":\"query\"},\"parameters\":{\"type\":\"string\",\"descriptio" +
            "n\":\"Event parameters in the form\\n:\\n.\",\"location\":\"query\"},\"startTime\":{\"type\":" +
            "\"string\",\"description\":\"Return events which occured at or after this time.\",\"loc" +
            "ation\":\"query\"}},\"parameterOrder\":[\"customerId\",\"applicationId\"],\"response\":{\"$r" +
            "ef\":\"Activities\"}}}}}}";
        
        private const string Version = "v1";
        
        private const string Name = "audit";
        
        private const string BaseUri = "https://www.googleapis.com/apps/reporting/audit/v1/";
        
        private const Google.Apis.Discovery.DiscoveryVersion DiscoveryVersionUsed = Google.Apis.Discovery.DiscoveryVersion.Version_1_0;
        
        private string key;
        
        private ActivitiesResource activities;
        
        protected AuditService(Google.Apis.Discovery.IService genericService, Google.Apis.Authentication.IAuthenticator authenticator) {
            this.genericService = genericService;
            this.authenticator = authenticator;
            this.activities = new ActivitiesResource(this);
        }
        
        public AuditService() : 
                this(Google.Apis.Authentication.NullAuthenticator.Instance) {
        }
        
        public AuditService(Google.Apis.Authentication.IAuthenticator authenticator) : 
                this(new Google.Apis.Discovery.DiscoveryService(new Google.Apis.Discovery.StringDiscoveryDevice(DiscoveryDocument)).GetService(AuditService.DiscoveryVersionUsed, new Google.Apis.Discovery.FactoryParameterV1_0(new System.Uri(AuditService.BaseUri))), authenticator) {
        }
        
        /// <summary>Sets the API-Key (or DeveloperKey) which this service uses for all requests</summary>
        public virtual string Key {
            get {
                return this.key;
            }
            set {
                this.key = value;
            }
        }
        
        public virtual ActivitiesResource Activities {
            get {
                return this.activities;
            }
        }
        
        public virtual Google.Apis.Requests.IRequest CreateRequest(string resource, string method) {
            Google.Apis.Requests.IRequest request = this.genericService.CreateRequest(resource, method);
            if (!string.IsNullOrEmpty(Key)) {
                request = request.WithKey(this.Key);
            }
            return request.WithAuthentication(authenticator);
        }
        
        public virtual void RegisterSerializer(Google.Apis.ISerializer serializer) {
            genericService.Serializer = serializer;
        }
        
        public virtual string SerializeObject(object obj) {
            return genericService.SerializeRequest(obj);
        }
        
        public virtual T DeserializeResponse<T>(Google.Apis.Requests.IResponse response)
         {
            return genericService.DeserializeResponse<T>(response);
        }
    }
    
    public class ActivitiesResource {
        
        private Google.Apis.Discovery.IRequestProvider service;
        
        private const string Resource = "activities";
        
        public ActivitiesResource(AuditService service) {
            this.service = service;
        }
        
        /// <summary>Retrieves a list of activities for a specific customer and application.</summary>
        /// <param name="customerId">Required - Must match pattern C.+ - Represents the customer who is the owner of target object on which action was performed.</param>
        /// <param name="applicationId">Required - Minimum value of -9223372036854775808 - Maximum value of 9223372036854775807 - Application ID of the application on which the event was performed.</param>
        public virtual ListRequest List(string customerId, long applicationId) {
            return new ListRequest(service, customerId, applicationId);
        }
        
        /// <summary>Retrieves a list of activities for a specific customer and application.</summary>
        /// <param name="customerId">Required - Must match pattern C.+ - Represents the customer who is the owner of target object on which action was performed.</param>
        /// <param name="applicationId">Required - Minimum value of -9223372036854775808 - Maximum value of 9223372036854775807 - Application ID of the application on which the event was performed.</param>
        /// <param name="actorApplicationId">Optional - Minimum value of -9223372036854775808 - Maximum value of 9223372036854775807 - Application ID of the application which interacted on behalf of the user while performing the event.</param>
        /// <param name="actorEmail">Optional - Email address of the user who performed the action.</param>
        /// <param name="caller">Optional - Must be one of the following values [application_owner, customer] - Type of the caller.</param>
        /// <param name="continuationToken">Optional - Next page URL.</param>
        /// <param name="endTime">Optional - Return events which occured at or before this time.</param>
        /// <param name="eventName">Optional - Name of the event being queried.</param>
        /// <param name="maxResults">Optional - Minimum value of 1 - Maximum value of 1000 - Number of activity records to be shown in each page.</param>
        /// <param name="parameters">Optional - Event parameters in the form
        ///:
        ///.</param>
        /// <param name="startTime">Optional - Return events which occured at or after this time.</param>
        public virtual ListRequest List(string customerId, long applicationId, [System.Runtime.InteropServices.OptionalAttribute()] System.Int64? actorApplicationId, [System.Runtime.InteropServices.OptionalAttribute()] string actorEmail, [System.Runtime.InteropServices.OptionalAttribute()] Caller? caller, [System.Runtime.InteropServices.OptionalAttribute()] string continuationToken, [System.Runtime.InteropServices.OptionalAttribute()] string endTime, [System.Runtime.InteropServices.OptionalAttribute()] string eventName, [System.Runtime.InteropServices.OptionalAttribute()] System.Int64? maxResults, [System.Runtime.InteropServices.OptionalAttribute()] string parameters, [System.Runtime.InteropServices.OptionalAttribute()] string startTime) {
            return new ListRequest(service, customerId, applicationId, actorApplicationId, actorEmail, caller, continuationToken, endTime, eventName, maxResults, parameters, startTime);
        }
        
        /// <summary>Type of the caller.</summary>
        [System.ComponentModel.TypeConverterAttribute(typeof(Google.Apis.Util.EnumStringValueTypeConverter))]
        public enum Caller {
            
            /// <summary>Caller is an application owner.</summary>
            [Google.Apis.Util.StringValueAttribute("application_owner")]
            Application_owner,
            
            /// <summary>Caller is a customer.</summary>
            [Google.Apis.Util.StringValueAttribute("customer")]
            Customer,
        }
        
        public class ListRequest : Google.Apis.Requests.ServiceRequest<Google.Apis.Audit.v1.Data.Activities> {
            
            private System.Int64? actorApplicationId;
            
            private string actorEmail;
            
            private long applicationId;
            
            private Caller? caller;
            
            private string continuationToken;
            
            private string customerId;
            
            private string endTime;
            
            private string eventName;
            
            private System.Int64? maxResults;
            
            private string parameters;
            
            private string startTime;
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, string customerId, long applicationId) : 
                    base(service) {
                this.customerId = customerId;
                this.applicationId = applicationId;
            }
            
            public ListRequest(Google.Apis.Discovery.IRequestProvider service, string customerId, long applicationId, [System.Runtime.InteropServices.OptionalAttribute()] System.Int64? actorApplicationId, [System.Runtime.InteropServices.OptionalAttribute()] string actorEmail, [System.Runtime.InteropServices.OptionalAttribute()] Caller? caller, [System.Runtime.InteropServices.OptionalAttribute()] string continuationToken, [System.Runtime.InteropServices.OptionalAttribute()] string endTime, [System.Runtime.InteropServices.OptionalAttribute()] string eventName, [System.Runtime.InteropServices.OptionalAttribute()] System.Int64? maxResults, [System.Runtime.InteropServices.OptionalAttribute()] string parameters, [System.Runtime.InteropServices.OptionalAttribute()] string startTime) : 
                    base(service) {
                this.customerId = customerId;
                this.applicationId = applicationId;
                this.actorApplicationId = actorApplicationId;
                this.actorEmail = actorEmail;
                this.caller = caller;
                this.continuationToken = continuationToken;
                this.endTime = endTime;
                this.eventName = eventName;
                this.maxResults = maxResults;
                this.parameters = parameters;
                this.startTime = startTime;
            }
            
            /// <summary>Application ID of the application which interacted on behalf of the user while performing the event.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorApplicationId")]
            public virtual System.Int64? ActorApplicationId {
                get {
                    return this.actorApplicationId;
                }
                set {
                    this.actorApplicationId = value;
                }
            }
            
            /// <summary>Email address of the user who performed the action.</summary>
            [Google.Apis.Util.RequestParameterAttribute("actorEmail")]
            public virtual string ActorEmail {
                get {
                    return this.actorEmail;
                }
                set {
                    this.actorEmail = value;
                }
            }
            
            /// <summary>Application ID of the application on which the event was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("applicationId")]
            public virtual long ApplicationId {
                get {
                    return this.applicationId;
                }
            }
            
            /// <summary>Type of the caller.</summary>
            [Google.Apis.Util.RequestParameterAttribute("caller")]
            public virtual Caller? Caller {
                get {
                    return this.caller;
                }
                set {
                    this.caller = value;
                }
            }
            
            /// <summary>Next page URL.</summary>
            [Google.Apis.Util.RequestParameterAttribute("continuationToken")]
            public virtual string ContinuationToken {
                get {
                    return this.continuationToken;
                }
                set {
                    this.continuationToken = value;
                }
            }
            
            /// <summary>Represents the customer who is the owner of target object on which action was performed.</summary>
            [Google.Apis.Util.RequestParameterAttribute("customerId")]
            public virtual string CustomerId {
                get {
                    return this.customerId;
                }
            }
            
            /// <summary>Return events which occured at or before this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("endTime")]
            public virtual string EndTime {
                get {
                    return this.endTime;
                }
                set {
                    this.endTime = value;
                }
            }
            
            /// <summary>Name of the event being queried.</summary>
            [Google.Apis.Util.RequestParameterAttribute("eventName")]
            public virtual string EventName {
                get {
                    return this.eventName;
                }
                set {
                    this.eventName = value;
                }
            }
            
            /// <summary>Number of activity records to be shown in each page.</summary>
            [Google.Apis.Util.RequestParameterAttribute("maxResults")]
            public virtual System.Int64? MaxResults {
                get {
                    return this.maxResults;
                }
                set {
                    this.maxResults = value;
                }
            }
            
            /// <summary>Event parameters in the form
            ///:
            ///.</summary>
            [Google.Apis.Util.RequestParameterAttribute("parameters")]
            public virtual string Parameters {
                get {
                    return this.parameters;
                }
                set {
                    this.parameters = value;
                }
            }
            
            /// <summary>Return events which occured at or after this time.</summary>
            [Google.Apis.Util.RequestParameterAttribute("startTime")]
            public virtual string StartTime {
                get {
                    return this.startTime;
                }
                set {
                    this.startTime = value;
                }
            }
            
            protected override string ResourceName {
                get {
                    return "activities";
                }
            }
            
            protected override string MethodName {
                get {
                    return "list";
                }
            }
        }
    }
}
