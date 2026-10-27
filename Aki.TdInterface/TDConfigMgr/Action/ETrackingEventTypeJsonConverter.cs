using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002480 RID: 9344
	public class ETrackingEventTypeJsonConverter : JsonConverter<ETrackingEventType>
	{
		// Token: 0x0600CAC0 RID: 51904 RVA: 0x001DD83C File Offset: 0x001DBA3C
		public override ETrackingEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackingEventType.EasterEgg;
			}
			return ETrackingEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAC1 RID: 51905 RVA: 0x001DD860 File Offset: 0x001DBA60
		public override void Write(Utf8JsonWriter writer, ETrackingEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
