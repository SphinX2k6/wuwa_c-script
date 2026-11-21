using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200544C RID: 21580
	public class EMatchThreeResourceIdJsonConverter : JsonConverter<EMatchThreeResourceId>
	{
		// Token: 0x060358F8 RID: 219384 RVA: 0x00EF5D9C File Offset: 0x00EF3F9C
		public override EMatchThreeResourceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeResourceId.TileNormal;
			}
			return EMatchThreeResourceIdExtensions.FromString(@string);
		}

		// Token: 0x060358F9 RID: 219385 RVA: 0x00EF5DC0 File Offset: 0x00EF3FC0
		public override void Write(Utf8JsonWriter writer, EMatchThreeResourceId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
