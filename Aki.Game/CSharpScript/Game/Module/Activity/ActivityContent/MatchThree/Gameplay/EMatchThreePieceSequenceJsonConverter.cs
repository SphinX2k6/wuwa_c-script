using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064CC RID: 25804
	public class EMatchThreePieceSequenceJsonConverter : JsonConverter<EMatchThreePieceSequence>
	{
		// Token: 0x06040C2B RID: 265259 RVA: 0x00FAE0D0 File Offset: 0x00FAC2D0
		public override EMatchThreePieceSequence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreePieceSequence.Recolor;
			}
			return EMatchThreePieceSequenceExtensions.FromString(@string);
		}

		// Token: 0x06040C2C RID: 265260 RVA: 0x00FAE0F4 File Offset: 0x00FAC2F4
		public override void Write(Utf8JsonWriter writer, EMatchThreePieceSequence value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
