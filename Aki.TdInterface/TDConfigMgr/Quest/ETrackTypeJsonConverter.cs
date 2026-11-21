using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F3 RID: 5107
	public class ETrackTypeJsonConverter : JsonConverter<ETrackType>
	{
		// Token: 0x06007221 RID: 29217 RVA: 0x00111200 File Offset: 0x0010F400
		public override ETrackType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackType.Locations;
			}
			return ETrackTypeExtensions.FromString(@string);
		}

		// Token: 0x06007222 RID: 29218 RVA: 0x00111224 File Offset: 0x0010F424
		public override void Write(Utf8JsonWriter writer, ETrackType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
