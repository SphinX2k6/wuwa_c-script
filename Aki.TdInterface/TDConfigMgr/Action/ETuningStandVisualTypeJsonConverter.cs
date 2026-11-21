using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002731 RID: 10033
	public class ETuningStandVisualTypeJsonConverter : JsonConverter<ETuningStandVisualType>
	{
		// Token: 0x0600D7B8 RID: 55224 RVA: 0x001F8560 File Offset: 0x001F6760
		public override ETuningStandVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETuningStandVisualType.Tuning;
			}
			return ETuningStandVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7B9 RID: 55225 RVA: 0x001F8584 File Offset: 0x001F6784
		public override void Write(Utf8JsonWriter writer, ETuningStandVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
