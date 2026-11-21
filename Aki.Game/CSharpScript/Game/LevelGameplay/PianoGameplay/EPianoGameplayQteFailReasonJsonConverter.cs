using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay.PianoGameplay
{
	// Token: 0x02005C2F RID: 23599
	public class EPianoGameplayQteFailReasonJsonConverter : JsonConverter<EPianoGameplayQteFailReason>
	{
		// Token: 0x06039F60 RID: 237408 RVA: 0x0104D764 File Offset: 0x0104B964
		public override EPianoGameplayQteFailReason Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPianoGameplayQteFailReason.Timeout;
			}
			return EPianoGameplayQteFailReasonExtensions.FromString(@string);
		}

		// Token: 0x06039F61 RID: 237409 RVA: 0x0104D788 File Offset: 0x0104B988
		public override void Write(Utf8JsonWriter writer, EPianoGameplayQteFailReason value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
