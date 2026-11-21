using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200544A RID: 21578
	public class EMatchThreePieceSequenceJsonConverter : JsonConverter<EMatchThreePieceSequence>
	{
		// Token: 0x060358EF RID: 219375 RVA: 0x00EF5118 File Offset: 0x00EF3318
		public override EMatchThreePieceSequence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreePieceSequence.Recolor;
			}
			return EMatchThreePieceSequenceExtensions.FromString(@string);
		}

		// Token: 0x060358F0 RID: 219376 RVA: 0x00EF513C File Offset: 0x00EF333C
		public override void Write(Utf8JsonWriter writer, EMatchThreePieceSequence value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
