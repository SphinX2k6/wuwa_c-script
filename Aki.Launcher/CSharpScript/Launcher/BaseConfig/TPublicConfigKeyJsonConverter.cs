using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Launcher.BaseConfig
{
	// Token: 0x0200027E RID: 638
	public class TPublicConfigKeyJsonConverter : JsonConverter<TPublicConfigKey>
	{
		// Token: 0x06000FA1 RID: 4001 RVA: 0x0005C880 File Offset: 0x0005AA80
		public override TPublicConfigKey Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return TPublicConfigKey.AppTag;
			}
			return TPublicConfigKeyExtensions.FromString(@string);
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0005C8A4 File Offset: 0x0005AAA4
		public override void Write(Utf8JsonWriter writer, TPublicConfigKey value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
