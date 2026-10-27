using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001257 RID: 4695
	public class EMechaTrackScoreDetectionTypeJsonConverter : JsonConverter<EMechaTrackScoreDetectionType>
	{
		// Token: 0x06006A30 RID: 27184 RVA: 0x000FE940 File Offset: 0x000FCB40
		public override EMechaTrackScoreDetectionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechaTrackScoreDetectionType.StuntAction;
			}
			return EMechaTrackScoreDetectionTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A31 RID: 27185 RVA: 0x000FE964 File Offset: 0x000FCB64
		public override void Write(Utf8JsonWriter writer, EMechaTrackScoreDetectionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
