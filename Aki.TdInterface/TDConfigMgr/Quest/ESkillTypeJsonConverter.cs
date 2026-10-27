using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128F RID: 4751
	public class ESkillTypeJsonConverter : JsonConverter<ESkillType>
	{
		// Token: 0x06006B2C RID: 27436 RVA: 0x00101434 File Offset: 0x000FF634
		public override ESkillType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkillType.NormalSkill;
			}
			return ESkillTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B2D RID: 27437 RVA: 0x00101458 File Offset: 0x000FF658
		public override void Write(Utf8JsonWriter writer, ESkillType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
