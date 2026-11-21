using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x02005446 RID: 21574
	public class EMatchThreeSkillSequenceJsonConverter : JsonConverter<EMatchThreeSkillSequence>
	{
		// Token: 0x060358DD RID: 219357 RVA: 0x00EF4EE4 File Offset: 0x00EF30E4
		public override EMatchThreeSkillSequence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeSkillSequence.Ultimate;
			}
			return EMatchThreeSkillSequenceExtensions.FromString(@string);
		}

		// Token: 0x060358DE RID: 219358 RVA: 0x00EF4F08 File Offset: 0x00EF3108
		public override void Write(Utf8JsonWriter writer, EMatchThreeSkillSequence value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
