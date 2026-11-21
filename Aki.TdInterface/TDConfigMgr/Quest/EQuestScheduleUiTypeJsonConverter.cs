using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B3 RID: 5043
	public class EQuestScheduleUiTypeJsonConverter : JsonConverter<EQuestScheduleUiType>
	{
		// Token: 0x06007101 RID: 28929 RVA: 0x0010DA68 File Offset: 0x0010BC68
		public override EQuestScheduleUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestScheduleUiType.Task;
			}
			return EQuestScheduleUiTypeExtensions.FromString(@string);
		}

		// Token: 0x06007102 RID: 28930 RVA: 0x0010DA8C File Offset: 0x0010BC8C
		public override void Write(Utf8JsonWriter writer, EQuestScheduleUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
