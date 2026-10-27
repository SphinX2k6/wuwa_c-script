using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200602C RID: 24620
	public class EComboBgTexturePathJsonConverter : JsonConverter<EComboBgTexturePath>
	{
		// Token: 0x0603E4FD RID: 255229 RVA: 0x00F0CA2C File Offset: 0x00F0AC2C
		public override EComboBgTexturePath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EComboBgTexturePath.Good;
			}
			return EComboBgTexturePathExtensions.FromString(@string);
		}

		// Token: 0x0603E4FE RID: 255230 RVA: 0x00F0CA50 File Offset: 0x00F0AC50
		public override void Write(Utf8JsonWriter writer, EComboBgTexturePath value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
