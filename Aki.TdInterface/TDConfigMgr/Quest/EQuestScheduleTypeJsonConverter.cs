using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001271 RID: 4721
	public class EQuestScheduleTypeJsonConverter : JsonConverter<EQuestScheduleType>
	{
		// Token: 0x06006AA5 RID: 27301 RVA: 0x000FFD28 File Offset: 0x000FDF28
		public override EQuestScheduleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestScheduleType.None;
			}
			return EQuestScheduleTypeExtensions.FromString(@string);
		}

		// Token: 0x06006AA6 RID: 27302 RVA: 0x000FFD4C File Offset: 0x000FDF4C
		public override void Write(Utf8JsonWriter writer, EQuestScheduleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
