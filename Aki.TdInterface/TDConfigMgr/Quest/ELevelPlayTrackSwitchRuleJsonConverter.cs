using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001393 RID: 5011
	public class ELevelPlayTrackSwitchRuleJsonConverter : JsonConverter<ELevelPlayTrackSwitchRule>
	{
		// Token: 0x06007071 RID: 28785 RVA: 0x0010C338 File Offset: 0x0010A538
		public override ELevelPlayTrackSwitchRule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
			}
			return ELevelPlayTrackSwitchRuleExtensions.FromString(@string);
		}

		// Token: 0x06007072 RID: 28786 RVA: 0x0010C35C File Offset: 0x0010A55C
		public override void Write(Utf8JsonWriter writer, ELevelPlayTrackSwitchRule value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
