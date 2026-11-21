using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FBC RID: 12220
	public class EComboTexturePathJsonConverter : JsonConverter<EComboTexturePath>
	{
		// Token: 0x0601D037 RID: 118839 RVA: 0x008DBE90 File Offset: 0x008DA090
		public override EComboTexturePath Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EComboTexturePath.Good;
			}
			return EComboTexturePathExtensions.FromString(@string);
		}

		// Token: 0x0601D038 RID: 118840 RVA: 0x008DBEB4 File Offset: 0x008DA0B4
		public override void Write(Utf8JsonWriter writer, EComboTexturePath value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
