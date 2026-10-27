using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064CA RID: 25802
	public class EMatchThreeSkillSequenceEventJsonConverter : JsonConverter<EMatchThreeSkillSequenceEvent>
	{
		// Token: 0x06040C22 RID: 265250 RVA: 0x00FADF78 File Offset: 0x00FAC178
		public override EMatchThreeSkillSequenceEvent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeSkillSequenceEvent.Up;
			}
			return EMatchThreeSkillSequenceEventExtensions.FromString(@string);
		}

		// Token: 0x06040C23 RID: 265251 RVA: 0x00FADF9C File Offset: 0x00FAC19C
		public override void Write(Utf8JsonWriter writer, EMatchThreeSkillSequenceEvent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
