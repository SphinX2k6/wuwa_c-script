using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001295 RID: 4757
	public class EStatisticsEventTypeJsonConverter : JsonConverter<EStatisticsEventType>
	{
		// Token: 0x06006B47 RID: 27463 RVA: 0x001019DC File Offset: 0x000FFBDC
		public override EStatisticsEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStatisticsEventType.Collect;
			}
			return EStatisticsEventTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B48 RID: 27464 RVA: 0x00101A00 File Offset: 0x000FFC00
		public override void Write(Utf8JsonWriter writer, EStatisticsEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
