using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BE RID: 2494
	public class EConnectorLogicTypeJsonConverter : JsonConverter<EConnectorLogicType>
	{
		// Token: 0x060037EB RID: 14315 RVA: 0x0009145C File Offset: 0x0008F65C
		public override EConnectorLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConnectorLogicType.Range;
			}
			return EConnectorLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x060037EC RID: 14316 RVA: 0x00091480 File Offset: 0x0008F680
		public override void Write(Utf8JsonWriter writer, EConnectorLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
