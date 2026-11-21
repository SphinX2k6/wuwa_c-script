using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025CF RID: 9679
	public class EHookTriggerTypeJsonConverter : JsonConverter<EHookTriggerType>
	{
		// Token: 0x0600D17F RID: 53631 RVA: 0x001E58D0 File Offset: 0x001E3AD0
		public override EHookTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookTriggerType.Motor;
			}
			return EHookTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D180 RID: 53632 RVA: 0x001E58F4 File Offset: 0x001E3AF4
		public override void Write(Utf8JsonWriter writer, EHookTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
