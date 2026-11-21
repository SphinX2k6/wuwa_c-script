using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F1 RID: 241
	public class ERestartTipTypeJsonConverter : JsonConverter<ERestartTipType>
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x0003EFB8 File Offset: 0x0003D1B8
		public override ERestartTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERestartTipType.HotFixComplete;
			}
			return ERestartTipTypeExtensions.FromString(@string);
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0003EFDC File Offset: 0x0003D1DC
		public override void Write(Utf8JsonWriter writer, ERestartTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
