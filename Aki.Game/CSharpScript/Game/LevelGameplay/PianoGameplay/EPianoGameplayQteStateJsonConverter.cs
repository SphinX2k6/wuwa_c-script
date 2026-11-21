using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C2D RID: 23597
	public class EPianoGameplayQteStateJsonConverter : JsonConverter<EPianoGameplayQteState>
	{
		// Token: 0x06039F57 RID: 237399 RVA: 0x0104D650 File Offset: 0x0104B850
		public override EPianoGameplayQteState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPianoGameplayQteState.Idle;
			}
			return EPianoGameplayQteStateExtensions.FromString(@string);
		}

		// Token: 0x06039F58 RID: 237400 RVA: 0x0104D674 File Offset: 0x0104B874
		public override void Write(Utf8JsonWriter writer, EPianoGameplayQteState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
