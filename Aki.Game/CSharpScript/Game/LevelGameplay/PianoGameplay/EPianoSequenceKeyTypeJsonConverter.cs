using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C2B RID: 23595
	public class EPianoSequenceKeyTypeJsonConverter : JsonConverter<EPianoSequenceKeyType>
	{
		// Token: 0x06039F4E RID: 237390 RVA: 0x0104D3DC File Offset: 0x0104B5DC
		public override EPianoSequenceKeyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPianoSequenceKeyType.ShowKey;
			}
			return EPianoSequenceKeyTypeExtensions.FromString(@string);
		}

		// Token: 0x06039F4F RID: 237391 RVA: 0x0104D400 File Offset: 0x0104B600
		public override void Write(Utf8JsonWriter writer, EPianoSequenceKeyType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
