using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235A RID: 9050
	public class EHookTriggerTypeJsonConverter : JsonConverter<EHookTriggerType>
	{
		// Token: 0x0600C595 RID: 50581 RVA: 0x001CD5F0 File Offset: 0x001CB7F0
		public override EHookTriggerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EHookTriggerType.Motor;
			}
			return EHookTriggerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C596 RID: 50582 RVA: 0x001CD614 File Offset: 0x001CB814
		public override void Write(Utf8JsonWriter writer, EHookTriggerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
