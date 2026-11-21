using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005448 RID: 21576
	public class EMatchThreeSkillSequenceEventJsonConverter : JsonConverter<EMatchThreeSkillSequenceEvent>
	{
		// Token: 0x060358E6 RID: 219366 RVA: 0x00EF4FC0 File Offset: 0x00EF31C0
		public override EMatchThreeSkillSequenceEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeSkillSequenceEvent.Up;
			}
			return EMatchThreeSkillSequenceEventExtensions.FromString(@string);
		}

		// Token: 0x060358E7 RID: 219367 RVA: 0x00EF4FE4 File Offset: 0x00EF31E4
		public override void Write(Utf8JsonWriter writer, EMatchThreeSkillSequenceEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
