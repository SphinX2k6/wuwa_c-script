using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000909 RID: 2313
	public class ECharacterConnectorLogicTypeJsonConverter : JsonConverter<ECharacterConnectorLogicType>
	{
		// Token: 0x0600345B RID: 13403 RVA: 0x00085AFC File Offset: 0x00083CFC
		public override ECharacterConnectorLogicType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECharacterConnectorLogicType.Range;
			}
			return ECharacterConnectorLogicTypeExtensions.FromString(@string);
		}

		// Token: 0x0600345C RID: 13404 RVA: 0x00085B20 File Offset: 0x00083D20
		public override void Write(Utf8JsonWriter writer, ECharacterConnectorLogicType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
