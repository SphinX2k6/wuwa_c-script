using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200248A RID: 9354
	public class ETuningStandBubbleTriggerTypeJsonConverter : JsonConverter<ETuningStandBubbleTriggerType>
	{
		// Token: 0x0600CAED RID: 51949 RVA: 0x001DDF64 File Offset: 0x001DC164
		public override ETuningStandBubbleTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETuningStandBubbleTriggerType.Enter;
			}
			return ETuningStandBubbleTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAEE RID: 51950 RVA: 0x001DDF88 File Offset: 0x001DC188
		public override void Write(Utf8JsonWriter writer, ETuningStandBubbleTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
