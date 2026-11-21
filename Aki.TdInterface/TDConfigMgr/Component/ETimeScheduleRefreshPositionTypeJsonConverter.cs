using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B02 RID: 2818
	public class ETimeScheduleRefreshPositionTypeJsonConverter : JsonConverter<ETimeScheduleRefreshPositionType>
	{
		// Token: 0x06003D9D RID: 15773 RVA: 0x0009D9A0 File Offset: 0x0009BBA0
		public override ETimeScheduleRefreshPositionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScheduleRefreshPositionType.FixedPositions;
			}
			return ETimeScheduleRefreshPositionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D9E RID: 15774 RVA: 0x0009D9C4 File Offset: 0x0009BBC4
		public override void Write(Utf8JsonWriter writer, ETimeScheduleRefreshPositionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
