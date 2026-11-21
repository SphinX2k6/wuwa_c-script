using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A02 RID: 2562
	public class EFrequencyPaintLineTypeJsonConverter : JsonConverter<EFrequencyPaintLineType>
	{
		// Token: 0x0600391D RID: 14621 RVA: 0x00093C54 File Offset: 0x00091E54
		public override EFrequencyPaintLineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFrequencyPaintLineType.Straight;
			}
			return EFrequencyPaintLineTypeExtensions.FromString(@string);
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00093C78 File Offset: 0x00091E78
		public override void Write(Utf8JsonWriter writer, EFrequencyPaintLineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
