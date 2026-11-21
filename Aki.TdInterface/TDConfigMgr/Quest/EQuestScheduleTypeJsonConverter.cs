using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B1 RID: 5041
	public class EQuestScheduleTypeJsonConverter : JsonConverter<EQuestScheduleType>
	{
		// Token: 0x060070F8 RID: 28920 RVA: 0x0010D954 File Offset: 0x0010BB54
		public override EQuestScheduleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestScheduleType.None;
			}
			return EQuestScheduleTypeExtensions.FromString(@string);
		}

		// Token: 0x060070F9 RID: 28921 RVA: 0x0010D978 File Offset: 0x0010BB78
		public override void Write(Utf8JsonWriter writer, EQuestScheduleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
