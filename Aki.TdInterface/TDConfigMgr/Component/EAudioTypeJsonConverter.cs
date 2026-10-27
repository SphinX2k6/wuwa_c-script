using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FF RID: 2303
	public class EAudioTypeJsonConverter : JsonConverter<EAudioType>
	{
		// Token: 0x0600342E RID: 13358 RVA: 0x00085558 File Offset: 0x00083758
		public override EAudioType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioType.AudioAMB;
			}
			return EAudioTypeExtensions.FromString(@string);
		}

		// Token: 0x0600342F RID: 13359 RVA: 0x0008557C File Offset: 0x0008377C
		public override void Write(Utf8JsonWriter writer, EAudioType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
