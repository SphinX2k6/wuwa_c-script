using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064D2 RID: 25810
	public class EMatchThreeTextIdJsonConverter : JsonConverter<EMatchThreeTextId>
	{
		// Token: 0x06040C46 RID: 265286 RVA: 0x00FAF220 File Offset: 0x00FAD420
		public override EMatchThreeTextId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeTextId.RemainingTurns;
			}
			return EMatchThreeTextIdExtensions.FromString(@string);
		}

		// Token: 0x06040C47 RID: 265287 RVA: 0x00FAF244 File Offset: 0x00FAD444
		public override void Write(Utf8JsonWriter writer, EMatchThreeTextId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
