using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.Game.Module.Activity.ActivityContent.Tetris
{
	// Token: 0x02002FC0 RID: 12224
	public class EComboTextColorJsonConverter : JsonConverter<EComboTextColor>
	{
		// Token: 0x0601D049 RID: 118857 RVA: 0x008DC258 File Offset: 0x008DA458
		public override EComboTextColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EComboTextColor.Good;
			}
			return EComboTextColorExtensions.FromString(@string);
		}

		// Token: 0x0601D04A RID: 118858 RVA: 0x008DC27C File Offset: 0x008DA47C
		public override void Write(Utf8JsonWriter writer, EComboTextColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
