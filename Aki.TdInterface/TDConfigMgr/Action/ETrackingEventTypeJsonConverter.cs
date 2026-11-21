using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002723 RID: 10019
	public class ETrackingEventTypeJsonConverter : JsonConverter<ETrackingEventType>
	{
		// Token: 0x0600D779 RID: 55161 RVA: 0x001F7A04 File Offset: 0x001F5C04
		public override ETrackingEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackingEventType.EasterEgg;
			}
			return ETrackingEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D77A RID: 55162 RVA: 0x001F7A28 File Offset: 0x001F5C28
		public override void Write(Utf8JsonWriter writer, ETrackingEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
