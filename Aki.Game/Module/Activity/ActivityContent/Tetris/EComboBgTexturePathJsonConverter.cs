using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FBE RID: 12222
	public class EComboBgTexturePathJsonConverter : JsonConverter<EComboBgTexturePath>
	{
		// Token: 0x0601D040 RID: 118848 RVA: 0x008DC074 File Offset: 0x008DA274
		public override EComboBgTexturePath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EComboBgTexturePath.Good;
			}
			return EComboBgTexturePathExtensions.FromString(@string);
		}

		// Token: 0x0601D041 RID: 118849 RVA: 0x008DC098 File Offset: 0x008DA298
		public override void Write(Utf8JsonWriter writer, EComboBgTexturePath value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
