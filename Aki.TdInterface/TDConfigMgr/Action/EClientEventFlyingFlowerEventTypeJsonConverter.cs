using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DC RID: 8924
	public class EClientEventFlyingFlowerEventTypeJsonConverter : JsonConverter<EClientEventFlyingFlowerEventType>
	{
		// Token: 0x0600C35E RID: 50014 RVA: 0x001C8BE8 File Offset: 0x001C6DE8
		public override EClientEventFlyingFlowerEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventFlyingFlowerEventType.UpdateSubtitle;
			}
			return EClientEventFlyingFlowerEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C35F RID: 50015 RVA: 0x001C8C0C File Offset: 0x001C6E0C
		public override void Write(Utf8JsonWriter writer, EClientEventFlyingFlowerEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
