using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000EF RID: 239
	public class EResourceQualityTierLabelJsonConverter : JsonConverter<EResourceQualityTierLabel>
	{
		// Token: 0x060007EB RID: 2027 RVA: 0x0003CD70 File Offset: 0x0003AF70
		public override EResourceQualityTierLabel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResourceQualityTierLabel.Smooth;
			}
			return EResourceQualityTierLabelExtensions.FromString(@string);
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0003CD94 File Offset: 0x0003AF94
		public override void Write(Utf8JsonWriter writer, EResourceQualityTierLabel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
