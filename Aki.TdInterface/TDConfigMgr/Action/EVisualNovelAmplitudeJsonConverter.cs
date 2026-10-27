using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A2 RID: 9378
	public class EVisualNovelAmplitudeJsonConverter : JsonConverter<EVisualNovelAmplitude>
	{
		// Token: 0x0600CB59 RID: 52057 RVA: 0x001DEF60 File Offset: 0x001DD160
		public override EVisualNovelAmplitude Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelAmplitude.Small;
			}
			return EVisualNovelAmplitudeExtensions.FromString(@string);
		}

		// Token: 0x0600CB5A RID: 52058 RVA: 0x001DEF84 File Offset: 0x001DD184
		public override void Write(Utf8JsonWriter writer, EVisualNovelAmplitude value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
