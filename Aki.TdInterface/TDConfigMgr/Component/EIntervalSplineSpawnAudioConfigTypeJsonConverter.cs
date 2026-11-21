using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A34 RID: 2612
	public class EIntervalSplineSpawnAudioConfigTypeJsonConverter : JsonConverter<EIntervalSplineSpawnAudioConfigType>
	{
		// Token: 0x060039FE RID: 14846 RVA: 0x00095E44 File Offset: 0x00094044
		public override EIntervalSplineSpawnAudioConfigType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EIntervalSplineSpawnAudioConfigType.AllActorAddAudio;
			}
			return EIntervalSplineSpawnAudioConfigTypeExtensions.FromString(@string);
		}

		// Token: 0x060039FF RID: 14847 RVA: 0x00095E68 File Offset: 0x00094068
		public override void Write(Utf8JsonWriter writer, EIntervalSplineSpawnAudioConfigType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
