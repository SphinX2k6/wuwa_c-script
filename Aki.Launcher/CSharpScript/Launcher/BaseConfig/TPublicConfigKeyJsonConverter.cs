using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x02000277 RID: 631
	public class TPublicConfigKeyJsonConverter : JsonConverter<TPublicConfigKey>
	{
		// Token: 0x06000F56 RID: 3926 RVA: 0x000598DC File Offset: 0x00057ADC
		public override TPublicConfigKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TPublicConfigKey.AppTag;
			}
			return TPublicConfigKeyExtensions.FromString(@string);
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00059900 File Offset: 0x00057B00
		public override void Write(Utf8JsonWriter writer, TPublicConfigKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
