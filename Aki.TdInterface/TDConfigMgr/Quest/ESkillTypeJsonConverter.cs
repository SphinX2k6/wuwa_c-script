using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013CF RID: 5071
	public class ESkillTypeJsonConverter : JsonConverter<ESkillType>
	{
		// Token: 0x0600717F RID: 29055 RVA: 0x0010F130 File Offset: 0x0010D330
		public override ESkillType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkillType.NormalSkill;
			}
			return ESkillTypeExtensions.FromString(@string);
		}

		// Token: 0x06007180 RID: 29056 RVA: 0x0010F154 File Offset: 0x0010D354
		public override void Write(Utf8JsonWriter writer, ESkillType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
