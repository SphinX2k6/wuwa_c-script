using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A39 RID: 2617
	public class ETimeScheduleDistributionTypeJsonConverter : JsonConverter<ETimeScheduleDistributionType>
	{
		// Token: 0x060039B3 RID: 14771 RVA: 0x00094EB4 File Offset: 0x000930B4
		public override ETimeScheduleDistributionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScheduleDistributionType.RandomSchedulePosition;
			}
			return ETimeScheduleDistributionTypeExtensions.FromString(@string);
		}

		// Token: 0x060039B4 RID: 14772 RVA: 0x00094ED8 File Offset: 0x000930D8
		public override void Write(Utf8JsonWriter writer, ETimeScheduleDistributionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
