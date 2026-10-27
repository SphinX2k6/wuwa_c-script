using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B9 RID: 4793
	public class EVisionSystemQuestTypeJsonConverter : JsonConverter<EVisionSystemQuestType>
	{
		// Token: 0x06006BE9 RID: 27625 RVA: 0x00103C18 File Offset: 0x00101E18
		public override EVisionSystemQuestType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisionSystemQuestType.HasVisionGetTargetLevel;
			}
			return EVisionSystemQuestTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BEA RID: 27626 RVA: 0x00103C3C File Offset: 0x00101E3C
		public override void Write(Utf8JsonWriter writer, EVisionSystemQuestType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
