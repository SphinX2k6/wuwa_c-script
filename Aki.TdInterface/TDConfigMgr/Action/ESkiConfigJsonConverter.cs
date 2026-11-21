using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B9 RID: 9913
	public class ESkiConfigJsonConverter : JsonConverter<ESkiConfig>
	{
		// Token: 0x0600D59C RID: 54684 RVA: 0x001F0BB0 File Offset: 0x001EEDB0
		public override ESkiConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkiConfig.Open;
			}
			return ESkiConfigExtensions.FromString(@string);
		}

		// Token: 0x0600D59D RID: 54685 RVA: 0x001F0BD4 File Offset: 0x001EEDD4
		public override void Write(Utf8JsonWriter writer, ESkiConfig value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
