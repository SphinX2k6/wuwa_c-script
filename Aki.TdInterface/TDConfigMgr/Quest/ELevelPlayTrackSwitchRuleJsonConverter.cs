using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001253 RID: 4691
	public class ELevelPlayTrackSwitchRuleJsonConverter : JsonConverter<ELevelPlayTrackSwitchRule>
	{
		// Token: 0x06006A1E RID: 27166 RVA: 0x000FE70C File Offset: 0x000FC90C
		public override ELevelPlayTrackSwitchRule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelPlayTrackSwitchRule.SwitchByLevelPlayTrack;
			}
			return ELevelPlayTrackSwitchRuleExtensions.FromString(@string);
		}

		// Token: 0x06006A1F RID: 27167 RVA: 0x000FE730 File Offset: 0x000FC930
		public override void Write(Utf8JsonWriter writer, ELevelPlayTrackSwitchRule value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
