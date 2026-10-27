using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000911 RID: 2321
	public class EConnectorLogicTypeJsonConverter : JsonConverter<EConnectorLogicType>
	{
		// Token: 0x0600347F RID: 13439 RVA: 0x000898DC File Offset: 0x00087ADC
		public override EConnectorLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConnectorLogicType.Range;
			}
			return EConnectorLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x06003480 RID: 13440 RVA: 0x00089900 File Offset: 0x00087B00
		public override void Write(Utf8JsonWriter writer, EConnectorLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
