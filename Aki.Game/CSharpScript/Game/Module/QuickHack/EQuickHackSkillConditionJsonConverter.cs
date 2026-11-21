using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02003F56 RID: 16214
	public class EQuickHackSkillConditionJsonConverter : JsonConverter<EQuickHackSkillCondition>
	{
		// Token: 0x060290D2 RID: 168146 RVA: 0x00B86B40 File Offset: 0x00B84D40
		public override EQuickHackSkillCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuickHackSkillCondition.CheckTargetTypeMatch;
			}
			return EQuickHackSkillConditionExtensions.FromString(@string);
		}

		// Token: 0x060290D3 RID: 168147 RVA: 0x00B86B64 File Offset: 0x00B84D64
		public override void Write(Utf8JsonWriter writer, EQuickHackSkillCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
