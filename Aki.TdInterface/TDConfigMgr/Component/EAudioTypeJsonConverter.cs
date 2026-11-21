using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009A8 RID: 2472
	public class EAudioTypeJsonConverter : JsonConverter<EAudioType>
	{
		// Token: 0x06003788 RID: 14216 RVA: 0x0008CDC8 File Offset: 0x0008AFC8
		public override EAudioType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAudioType.AudioAMB;
			}
			return EAudioTypeExtensions.FromString(@string);
		}

		// Token: 0x06003789 RID: 14217 RVA: 0x0008CDEC File Offset: 0x0008AFEC
		public override void Write(Utf8JsonWriter writer, EAudioType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
