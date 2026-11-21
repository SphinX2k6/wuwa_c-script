using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013FF RID: 5119
	public class EVisionSystemQuestTypeJsonConverter : JsonConverter<EVisionSystemQuestType>
	{
		// Token: 0x06007257 RID: 29271 RVA: 0x00111BE0 File Offset: 0x0010FDE0
		public override EVisionSystemQuestType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisionSystemQuestType.HasVisionGetTargetLevel;
			}
			return EVisionSystemQuestTypeExtensions.FromString(@string);
		}

		// Token: 0x06007258 RID: 29272 RVA: 0x00111C04 File Offset: 0x0010FE04
		public override void Write(Utf8JsonWriter writer, EVisionSystemQuestType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
