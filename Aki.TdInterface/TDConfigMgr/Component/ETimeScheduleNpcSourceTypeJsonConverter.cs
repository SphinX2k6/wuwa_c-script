using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B00 RID: 2816
	public class ETimeScheduleNpcSourceTypeJsonConverter : JsonConverter<ETimeScheduleNpcSourceType>
	{
		// Token: 0x06003D94 RID: 15764 RVA: 0x0009D8C4 File Offset: 0x0009BAC4
		public override ETimeScheduleNpcSourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScheduleNpcSourceType.EntityTemplate;
			}
			return ETimeScheduleNpcSourceTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D95 RID: 15765 RVA: 0x0009D8E8 File Offset: 0x0009BAE8
		public override void Write(Utf8JsonWriter writer, ETimeScheduleNpcSourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
