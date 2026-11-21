using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001397 RID: 5015
	public class EMechaTrackScoreDetectionTypeJsonConverter : JsonConverter<EMechaTrackScoreDetectionType>
	{
		// Token: 0x06007083 RID: 28803 RVA: 0x0010C56C File Offset: 0x0010A76C
		public override EMechaTrackScoreDetectionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechaTrackScoreDetectionType.StuntAction;
			}
			return EMechaTrackScoreDetectionTypeExtensions.FromString(@string);
		}

		// Token: 0x06007084 RID: 28804 RVA: 0x0010C590 File Offset: 0x0010A790
		public override void Write(Utf8JsonWriter writer, EMechaTrackScoreDetectionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
