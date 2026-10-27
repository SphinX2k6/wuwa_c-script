using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002352 RID: 9042
	public class EGuideTriggerTypeJsonConverter : JsonConverter<EGuideTriggerType>
	{
		// Token: 0x0600C571 RID: 50545 RVA: 0x001CD0F0 File Offset: 0x001CB2F0
		public override EGuideTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuideTriggerType.BeginnerGuide;
			}
			return EGuideTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C572 RID: 50546 RVA: 0x001CD114 File Offset: 0x001CB314
		public override void Write(Utf8JsonWriter writer, EGuideTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
