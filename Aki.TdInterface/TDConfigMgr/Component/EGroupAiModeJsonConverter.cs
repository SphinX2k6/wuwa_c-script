using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095D RID: 2397
	public class EGroupAiModeJsonConverter : JsonConverter<EGroupAiMode>
	{
		// Token: 0x060035D5 RID: 13781 RVA: 0x0008C3F0 File Offset: 0x0008A5F0
		public override EGroupAiMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiMode.Default;
			}
			return EGroupAiModeExtensions.FromString(@string);
		}

		// Token: 0x060035D6 RID: 13782 RVA: 0x0008C414 File Offset: 0x0008A614
		public override void Write(Utf8JsonWriter writer, EGroupAiMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
