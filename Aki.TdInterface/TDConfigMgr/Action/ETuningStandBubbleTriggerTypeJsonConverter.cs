using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200272D RID: 10029
	public class ETuningStandBubbleTriggerTypeJsonConverter : JsonConverter<ETuningStandBubbleTriggerType>
	{
		// Token: 0x0600D7A6 RID: 55206 RVA: 0x001F812C File Offset: 0x001F632C
		public override ETuningStandBubbleTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETuningStandBubbleTriggerType.Enter;
			}
			return ETuningStandBubbleTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D7A7 RID: 55207 RVA: 0x001F8150 File Offset: 0x001F6350
		public override void Write(Utf8JsonWriter writer, ETuningStandBubbleTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
