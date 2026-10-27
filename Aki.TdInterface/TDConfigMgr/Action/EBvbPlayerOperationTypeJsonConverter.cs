using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022C8 RID: 8904
	public class EBvbPlayerOperationTypeJsonConverter : JsonConverter<EBvbPlayerOperationType>
	{
		// Token: 0x0600C304 RID: 49924 RVA: 0x001C8080 File Offset: 0x001C6280
		public override EBvbPlayerOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBvbPlayerOperationType.BvbDeploy;
			}
			return EBvbPlayerOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C305 RID: 49925 RVA: 0x001C80A4 File Offset: 0x001C62A4
		public override void Write(Utf8JsonWriter writer, EBvbPlayerOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
