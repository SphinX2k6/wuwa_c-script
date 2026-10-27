using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3B RID: 2619
	public class ETimeScheduleNpcSourceTypeJsonConverter : JsonConverter<ETimeScheduleNpcSourceType>
	{
		// Token: 0x060039BC RID: 14780 RVA: 0x00094F90 File Offset: 0x00093190
		public override ETimeScheduleNpcSourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeScheduleNpcSourceType.EntityTemplate;
			}
			return ETimeScheduleNpcSourceTypeExtensions.FromString(@string);
		}

		// Token: 0x060039BD RID: 14781 RVA: 0x00094FB4 File Offset: 0x000931B4
		public override void Write(Utf8JsonWriter writer, ETimeScheduleNpcSourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
