using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B5 RID: 4789
	public class EUseSkillCheckTypeJsonConverter : JsonConverter<EUseSkillCheckType>
	{
		// Token: 0x06006BD7 RID: 27607 RVA: 0x001039AC File Offset: 0x00101BAC
		public override EUseSkillCheckType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUseSkillCheckType.CheckSkillGenre;
			}
			return EUseSkillCheckTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BD8 RID: 27608 RVA: 0x001039D0 File Offset: 0x00101BD0
		public override void Write(Utf8JsonWriter writer, EUseSkillCheckType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
