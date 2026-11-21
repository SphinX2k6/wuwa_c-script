using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013FB RID: 5115
	public class EUseSkillCheckTypeJsonConverter : JsonConverter<EUseSkillCheckType>
	{
		// Token: 0x06007245 RID: 29253 RVA: 0x00111974 File Offset: 0x0010FB74
		public override EUseSkillCheckType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUseSkillCheckType.CheckSkillGenre;
			}
			return EUseSkillCheckTypeExtensions.FromString(@string);
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x00111998 File Offset: 0x0010FB98
		public override void Write(Utf8JsonWriter writer, EUseSkillCheckType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
