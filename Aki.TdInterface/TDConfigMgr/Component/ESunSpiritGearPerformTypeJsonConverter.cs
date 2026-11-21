using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AEA RID: 2794
	public class ESunSpiritGearPerformTypeJsonConverter : JsonConverter<ESunSpiritGearPerformType>
	{
		// Token: 0x06003D31 RID: 15665 RVA: 0x0009CBF0 File Offset: 0x0009ADF0
		public override ESunSpiritGearPerformType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESunSpiritGearPerformType.ToGearRelativePos;
			}
			return ESunSpiritGearPerformTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D32 RID: 15666 RVA: 0x0009CC14 File Offset: 0x0009AE14
		public override void Write(Utf8JsonWriter writer, ESunSpiritGearPerformType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
