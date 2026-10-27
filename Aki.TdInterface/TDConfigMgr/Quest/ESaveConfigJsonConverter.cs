using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128B RID: 4747
	public class ESaveConfigJsonConverter : JsonConverter<ESaveConfig>
	{
		// Token: 0x06006B1A RID: 27418 RVA: 0x00100EC0 File Offset: 0x000FF0C0
		public override ESaveConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESaveConfig.SaveNew;
			}
			return ESaveConfigExtensions.FromString(@string);
		}

		// Token: 0x06006B1B RID: 27419 RVA: 0x00100EE4 File Offset: 0x000FF0E4
		public override void Write(Utf8JsonWriter writer, ESaveConfig value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
