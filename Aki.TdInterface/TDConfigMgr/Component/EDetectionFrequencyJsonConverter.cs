using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000921 RID: 2337
	public class EDetectionFrequencyJsonConverter : JsonConverter<EDetectionFrequency>
	{
		// Token: 0x060034C7 RID: 13511 RVA: 0x0008A0D8 File Offset: 0x000882D8
		public override EDetectionFrequency Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectionFrequency.Low;
			}
			return EDetectionFrequencyExtensions.FromString(@string);
		}

		// Token: 0x060034C8 RID: 13512 RVA: 0x0008A0FC File Offset: 0x000882FC
		public override void Write(Utf8JsonWriter writer, EDetectionFrequency value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
