// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure;
using Microsoft.Azure.Management.Sql.LegacySdk.Models;

namespace Microsoft.Azure.Management.Sql.LegacySdk
{
    /// <summary>
    /// Represents all the operations for operating on Azure SQL Server
    /// communication links.  Contains operations to: Create, Retrieve,
    /// Update, and Delete.
    /// </summary>
    public partial interface IServerCommunicationLinkOperations
    {
        /// <summary>
        /// Begins creating a new or updating an existing Azure SQL Server
        /// communication. To determine the status of the operation call
        /// GetServerCommunicationLinkOperationStatus.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// The name of the Azure SQL Server communication link to be operated
        /// on (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a Server
        /// communication link.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        Task<ServerCommunicationLinkCreateOrUpdateResponse> BeginCreateOrUpdateAsync(string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLinkCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Creates a new or updates an existing Azure SQL Server communication
        /// link.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Database
        /// Server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// The name of the Azure SQL Server communication link to be operated
        /// on (Updated or created).
        /// </param>
        /// <param name='parameters'>
        /// The required parameters for creating or updating a Server
        /// communication link.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        Task<ServerCommunicationLinkCreateOrUpdateResponse> CreateOrUpdateAsync(string resourceGroupName, string serverName, string communicationLinkName, ServerCommunicationLinkCreateOrUpdateParameters parameters, CancellationToken cancellationToken);
        
        /// <summary>
        /// Deletes the Azure SQL server communication link with the given name.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// The name of the Azure SQL server communication link to be retrieved.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// A standard service response including an HTTP status code and
        /// request ID.
        /// </returns>
        Task<AzureOperationResponse> DeleteAsync(string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns information about an Azure SQL Server communication links.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the server belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='communicationLinkName'>
        /// The name of the Azure SQL server communication link to be retrieved.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a get server communication link request.
        /// </returns>
        Task<ServerCommunicationLinkGetResponse> GetAsync(string resourceGroupName, string serverName, string communicationLinkName, CancellationToken cancellationToken);
        
        /// <summary>
        /// Gets the status of an Azure Sql Server communication link create or
        /// update operation.
        /// </summary>
        /// <param name='operationStatusLink'>
        /// Location value returned by the Begin operation
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Response for long running Azure Sql server communication link
        /// operation.
        /// </returns>
        Task<ServerCommunicationLinkCreateOrUpdateResponse> GetServerCommunicationLinkOperationStatusAsync(string operationStatusLink, CancellationToken cancellationToken);
        
        /// <summary>
        /// Returns information about Azure SQL Server communication links.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The name of the Resource Group to which the Azure SQL Server
        /// belongs.
        /// </param>
        /// <param name='serverName'>
        /// The name of the Azure SQL Server.
        /// </param>
        /// <param name='cancellationToken'>
        /// Cancellation token.
        /// </param>
        /// <returns>
        /// Represents the response to a List Azure Sql Server communication
        /// link request.
        /// </returns>
        Task<ServerCommunicationLinkListResponse> ListAsync(string resourceGroupName, string serverName, CancellationToken cancellationToken);
    }
}
