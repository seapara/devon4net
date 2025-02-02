﻿namespace Devon4Net.Infrastructure.Nexus.Model.Components.UploadComponent
{
    public class NpmUploadComponent : UploadComponent
    {
        public override MultipartFormDataContent GetMultiPartFormData(ByteArrayContent fileContent)
        {
            return new MultipartFormDataContent
            {
                { fileContent, "npm.asset" },
            };
        }
    }
}
