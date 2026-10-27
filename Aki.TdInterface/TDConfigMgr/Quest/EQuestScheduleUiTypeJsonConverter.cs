using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001273 RID: 4723
	public class EQuestScheduleUiTypeJsonConverter : JsonConverter<EQuestScheduleUiType>
	{
		// Token: 0x06006AAE RID: 27310 RVA: 0x000FFE3C File Offset: 0x000FE03C
		public override EQuestScheduleUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestScheduleUiType.Task;
			}
			return EQuestScheduleUiTypeExtensions.FromString(@string);
		}

		// Token: 0x06006AAF RID: 27311 RVA: 0x000FFE60 File Offset: 0x000FE060
		public override void Write(Utf8JsonWriter writer, EQuestScheduleUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
