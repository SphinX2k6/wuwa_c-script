using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A25 RID: 2597
	public class ESunSpiritGearPerformTypeJsonConverter : JsonConverter<ESunSpiritGearPerformType>
	{
		// Token: 0x06003959 RID: 14681 RVA: 0x000942BC File Offset: 0x000924BC
		public override ESunSpiritGearPerformType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESunSpiritGearPerformType.ToGearRelativePos;
			}
			return ESunSpiritGearPerformTypeExtensions.FromString(@string);
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x000942E0 File Offset: 0x000924E0
		public override void Write(Utf8JsonWriter writer, ESunSpiritGearPerformType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
