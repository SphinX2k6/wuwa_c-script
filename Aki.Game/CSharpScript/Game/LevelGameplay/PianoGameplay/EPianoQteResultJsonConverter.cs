using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C31 RID: 23601
	public class EPianoQteResultJsonConverter : JsonConverter<EPianoQteResult>
	{
		// Token: 0x06039F69 RID: 237417 RVA: 0x0104D8BC File Offset: 0x0104BABC
		public override EPianoQteResult Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPianoQteResult.Success;
			}
			return EPianoQteResultExtensions.FromString(@string);
		}

		// Token: 0x06039F6A RID: 237418 RVA: 0x0104D8E0 File Offset: 0x0104BAE0
		public override void Write(Utf8JsonWriter writer, EPianoQteResult value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
