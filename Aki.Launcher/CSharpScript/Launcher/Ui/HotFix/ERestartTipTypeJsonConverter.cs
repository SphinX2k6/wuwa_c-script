using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000ED RID: 237
	public class ERestartTipTypeJsonConverter : JsonConverter<ERestartTipType>
	{
		// Token: 0x060007E2 RID: 2018 RVA: 0x0003CC18 File Offset: 0x0003AE18
		public override ERestartTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERestartTipType.HotFixComplete;
			}
			return ERestartTipTypeExtensions.FromString(@string);
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0003CC3C File Offset: 0x0003AE3C
		public override void Write(Utf8JsonWriter writer, ERestartTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
