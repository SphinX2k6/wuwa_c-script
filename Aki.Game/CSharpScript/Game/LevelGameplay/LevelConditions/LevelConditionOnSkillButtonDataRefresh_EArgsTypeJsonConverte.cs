using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F21 RID: 24353
	public class LevelConditionOnSkillButtonDataRefresh_EArgsTypeJsonConverter : JsonConverter<LevelConditionOnSkillButtonDataRefresh.EArgsType>
	{
		// Token: 0x0603A968 RID: 239976 RVA: 0x0108EDB0 File Offset: 0x0108CFB0
		public override LevelConditionOnSkillButtonDataRefresh.EArgsType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType;
			}
			return LevelConditionOnSkillButtonDataRefresh_EArgsTypeExtensions.FromString(@string);
		}

		// Token: 0x0603A969 RID: 239977 RVA: 0x0108EDD4 File Offset: 0x0108CFD4
		public override void Write(Utf8JsonWriter writer, LevelConditionOnSkillButtonDataRefresh.EArgsType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
