using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.Ui.HotFix
{
	// Token: 0x020000F3 RID: 243
	public class EResourceQualityTierLabelJsonConverter : JsonConverter<EResourceQualityTierLabel>
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x0003F110 File Offset: 0x0003D310
		public override EResourceQualityTierLabel Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResourceQualityTierLabel.Smooth;
			}
			return EResourceQualityTierLabelExtensions.FromString(@string);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x0003F134 File Offset: 0x0003D334
		public override void Write(Utf8JsonWriter writer, EResourceQualityTierLabel value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
