using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CE RID: 2510
	public class EDetectionFrequencyJsonConverter : JsonConverter<EDetectionFrequency>
	{
		// Token: 0x06003833 RID: 14387 RVA: 0x00091C58 File Offset: 0x0008FE58
		public override EDetectionFrequency Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectionFrequency.Low;
			}
			return EDetectionFrequencyExtensions.FromString(@string);
		}

		// Token: 0x06003834 RID: 14388 RVA: 0x00091C7C File Offset: 0x0008FE7C
		public override void Write(Utf8JsonWriter writer, EDetectionFrequency value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
