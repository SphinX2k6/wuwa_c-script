using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x0200602E RID: 24622
	public class EComboTextColorJsonConverter : JsonConverter<EComboTextColor>
	{
		// Token: 0x0603E506 RID: 255238 RVA: 0x00F0CC10 File Offset: 0x00F0AE10
		public override EComboTextColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EComboTextColor.Good;
			}
			return EComboTextColorExtensions.FromString(@string);
		}

		// Token: 0x0603E507 RID: 255239 RVA: 0x00F0CC34 File Offset: 0x00F0AE34
		public override void Write(Utf8JsonWriter writer, EComboTextColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
