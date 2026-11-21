using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002745 RID: 10053
	public class EVisualNovelAmplitudeJsonConverter : JsonConverter<EVisualNovelAmplitude>
	{
		// Token: 0x0600D812 RID: 55314 RVA: 0x001F9128 File Offset: 0x001F7328
		public override EVisualNovelAmplitude Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelAmplitude.Small;
			}
			return EVisualNovelAmplitudeExtensions.FromString(@string);
		}

		// Token: 0x0600D813 RID: 55315 RVA: 0x001F914C File Offset: 0x001F734C
		public override void Write(Utf8JsonWriter writer, EVisualNovelAmplitude value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
