using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064C8 RID: 25800
	public class EMatchThreeSkillSequenceJsonConverter : JsonConverter<EMatchThreeSkillSequence>
	{
		// Token: 0x06040C19 RID: 265241 RVA: 0x00FADE9C File Offset: 0x00FAC09C
		public override EMatchThreeSkillSequence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeSkillSequence.Ultimate;
			}
			return EMatchThreeSkillSequenceExtensions.FromString(@string);
		}

		// Token: 0x06040C1A RID: 265242 RVA: 0x00FADEC0 File Offset: 0x00FAC0C0
		public override void Write(Utf8JsonWriter writer, EMatchThreeSkillSequence value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
