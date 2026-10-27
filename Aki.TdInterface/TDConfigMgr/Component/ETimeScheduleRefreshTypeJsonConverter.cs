using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3D RID: 2621
	public class ETimeScheduleRefreshTypeJsonConverter : JsonConverter<ETimeScheduleRefreshType>
	{
		// Token: 0x060039C5 RID: 14789 RVA: 0x0009506C File Offset: 0x0009326C
		public override ETimeScheduleRefreshType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScheduleRefreshType.GameDaily;
			}
			return ETimeScheduleRefreshTypeExtensions.FromString(@string);
		}

		// Token: 0x060039C6 RID: 14790 RVA: 0x00095090 File Offset: 0x00093290
		public override void Write(Utf8JsonWriter writer, ETimeScheduleRefreshType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
