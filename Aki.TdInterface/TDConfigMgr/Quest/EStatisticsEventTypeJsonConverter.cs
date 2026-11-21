using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D7 RID: 5079
	public class EStatisticsEventTypeJsonConverter : JsonConverter<EStatisticsEventType>
	{
		// Token: 0x060071A3 RID: 29091 RVA: 0x0010F7B4 File Offset: 0x0010D9B4
		public override EStatisticsEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStatisticsEventType.Collect;
			}
			return EStatisticsEventTypeExtensions.FromString(@string);
		}

		// Token: 0x060071A4 RID: 29092 RVA: 0x0010F7D8 File Offset: 0x0010D9D8
		public override void Write(Utf8JsonWriter writer, EStatisticsEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
