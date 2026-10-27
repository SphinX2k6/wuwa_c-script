using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200602A RID: 24618
	public class EComboTexturePathJsonConverter : JsonConverter<EComboTexturePath>
	{
		// Token: 0x0603E4F4 RID: 255220 RVA: 0x00F0C848 File Offset: 0x00F0AA48
		public override EComboTexturePath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EComboTexturePath.Good;
			}
			return EComboTexturePathExtensions.FromString(@string);
		}

		// Token: 0x0603E4F5 RID: 255221 RVA: 0x00F0C86C File Offset: 0x00F0AA6C
		public override void Write(Utf8JsonWriter writer, EComboTexturePath value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
