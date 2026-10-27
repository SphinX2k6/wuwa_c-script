using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002438 RID: 9272
	public class ESubScreenOperationTypeJsonConverter : JsonConverter<ESubScreenOperationType>
	{
		// Token: 0x0600C97C RID: 51580 RVA: 0x001D80E4 File Offset: 0x001D62E4
		public override ESubScreenOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubScreenOperationType.Init;
			}
			return ESubScreenOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C97D RID: 51581 RVA: 0x001D8108 File Offset: 0x001D6308
		public override void Write(Utf8JsonWriter writer, ESubScreenOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
