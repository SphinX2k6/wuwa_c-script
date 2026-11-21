using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025C5 RID: 9669
	public class EGuideTriggerTypeJsonConverter : JsonConverter<EGuideTriggerType>
	{
		// Token: 0x0600D152 RID: 53586 RVA: 0x001E52BC File Offset: 0x001E34BC
		public override EGuideTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGuideTriggerType.BeginnerGuide;
			}
			return EGuideTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D153 RID: 53587 RVA: 0x001E52E0 File Offset: 0x001E34E0
		public override void Write(Utf8JsonWriter writer, EGuideTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
