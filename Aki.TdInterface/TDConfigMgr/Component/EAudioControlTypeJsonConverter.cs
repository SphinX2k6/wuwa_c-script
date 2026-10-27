using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008FB RID: 2299
	public class EAudioControlTypeJsonConverter : JsonConverter<EAudioControlType>
	{
		// Token: 0x0600341C RID: 13340 RVA: 0x000852EC File Offset: 0x000834EC
		public override EAudioControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioControlType.Gramophone;
			}
			return EAudioControlTypeExtensions.FromString(@string);
		}

		// Token: 0x0600341D RID: 13341 RVA: 0x00085310 File Offset: 0x00083510
		public override void Write(Utf8JsonWriter writer, EAudioControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
