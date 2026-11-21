using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013CB RID: 5067
	public class ESaveConfigJsonConverter : JsonConverter<ESaveConfig>
	{
		// Token: 0x0600716D RID: 29037 RVA: 0x0010EBBC File Offset: 0x0010CDBC
		public override ESaveConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESaveConfig.SaveNew;
			}
			return ESaveConfigExtensions.FromString(@string);
		}

		// Token: 0x0600716E RID: 29038 RVA: 0x0010EBE0 File Offset: 0x0010CDE0
		public override void Write(Utf8JsonWriter writer, ESaveConfig value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
