using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AFE RID: 2814
	public class ETimeScheduleGenerateTypeJsonConverter : JsonConverter<ETimeScheduleGenerateType>
	{
		// Token: 0x06003D8B RID: 15755 RVA: 0x0009D7E8 File Offset: 0x0009B9E8
		public override ETimeScheduleGenerateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScheduleGenerateType.FixedIntervalRefresh;
			}
			return ETimeScheduleGenerateTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D8C RID: 15756 RVA: 0x0009D80C File Offset: 0x0009BA0C
		public override void Write(Utf8JsonWriter writer, ETimeScheduleGenerateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
