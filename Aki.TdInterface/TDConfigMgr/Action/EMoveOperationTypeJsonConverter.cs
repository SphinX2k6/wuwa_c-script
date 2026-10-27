using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200239E RID: 9118
	public class EMoveOperationTypeJsonConverter : JsonConverter<EMoveOperationType>
	{
		// Token: 0x0600C6C7 RID: 50887 RVA: 0x001D1BB8 File Offset: 0x001CFDB8
		public override EMoveOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoveOperationType.Enable;
			}
			return EMoveOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6C8 RID: 50888 RVA: 0x001D1BDC File Offset: 0x001CFDDC
		public override void Write(Utf8JsonWriter writer, EMoveOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
