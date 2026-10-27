using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000981 RID: 2433
	public class EIntervalSplineSpawnAudioConfigTypeJsonConverter : JsonConverter<EIntervalSplineSpawnAudioConfigType>
	{
		// Token: 0x06003677 RID: 13943 RVA: 0x0008DED8 File Offset: 0x0008C0D8
		public override EIntervalSplineSpawnAudioConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
			}
			return EIntervalSplineSpawnAudioConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x06003678 RID: 13944 RVA: 0x0008DEFC File Offset: 0x0008C0FC
		public override void Write(Utf8JsonWriter writer, EIntervalSplineSpawnAudioConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
