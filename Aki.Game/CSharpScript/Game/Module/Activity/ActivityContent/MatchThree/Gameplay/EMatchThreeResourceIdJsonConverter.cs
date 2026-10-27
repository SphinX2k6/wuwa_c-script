using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064CE RID: 25806
	public class EMatchThreeResourceIdJsonConverter : JsonConverter<EMatchThreeResourceId>
	{
		// Token: 0x06040C34 RID: 265268 RVA: 0x00FAED54 File Offset: 0x00FACF54
		public override EMatchThreeResourceId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeResourceId.TileNormal;
			}
			return EMatchThreeResourceIdExtensions.FromString(@string);
		}

		// Token: 0x06040C35 RID: 265269 RVA: 0x00FAED78 File Offset: 0x00FACF78
		public override void Write(Utf8JsonWriter writer, EMatchThreeResourceId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
