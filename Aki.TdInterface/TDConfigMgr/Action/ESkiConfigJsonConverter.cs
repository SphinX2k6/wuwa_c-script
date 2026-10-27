using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241A RID: 9242
	public class ESkiConfigJsonConverter : JsonConverter<ESkiConfig>
	{
		// Token: 0x0600C8F5 RID: 51445 RVA: 0x001D6EDC File Offset: 0x001D50DC
		public override ESkiConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESkiConfig.Open;
			}
			return ESkiConfigExtensions.FromString(@string);
		}

		// Token: 0x0600C8F6 RID: 51446 RVA: 0x001D6F00 File Offset: 0x001D5100
		public override void Write(Utf8JsonWriter writer, ESkiConfig value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
