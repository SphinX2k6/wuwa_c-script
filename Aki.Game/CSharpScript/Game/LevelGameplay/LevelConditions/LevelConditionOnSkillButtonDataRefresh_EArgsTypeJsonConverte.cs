using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006DA2 RID: 28066
	public class LevelConditionOnSkillButtonDataRefresh_EArgsTypeJsonConverter : JsonConverter<LevelConditionOnSkillButtonDataRefresh.EArgsType>
	{
		// Token: 0x06044804 RID: 280580 RVA: 0x010E4B88 File Offset: 0x010E2D88
		public override LevelConditionOnSkillButtonDataRefresh.EArgsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType;
			}
			return LevelConditionOnSkillButtonDataRefresh_EArgsTypeExtensions.FromString(@string);
		}

		// Token: 0x06044805 RID: 280581 RVA: 0x010E4BAC File Offset: 0x010E2DAC
		public override void Write(Utf8JsonWriter writer, LevelConditionOnSkillButtonDataRefresh.EArgsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
