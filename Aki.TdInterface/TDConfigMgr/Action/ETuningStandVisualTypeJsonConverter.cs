using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248E RID: 9358
	public class ETuningStandVisualTypeJsonConverter : JsonConverter<ETuningStandVisualType>
	{
		// Token: 0x0600CAFF RID: 51967 RVA: 0x001DE398 File Offset: 0x001DC598
		public override ETuningStandVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETuningStandVisualType.Tuning;
			}
			return ETuningStandVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB00 RID: 51968 RVA: 0x001DE3BC File Offset: 0x001DC5BC
		public override void Write(Utf8JsonWriter writer, ETuningStandVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
