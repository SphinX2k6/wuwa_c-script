using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200254B RID: 9547
	public class EClientEventFlyingFlowerEventTypeJsonConverter : JsonConverter<EClientEventFlyingFlowerEventType>
	{
		// Token: 0x0600CF2D RID: 53037 RVA: 0x001E09F0 File Offset: 0x001DEBF0
		public override EClientEventFlyingFlowerEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventFlyingFlowerEventType.UpdateSubtitle;
			}
			return EClientEventFlyingFlowerEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF2E RID: 53038 RVA: 0x001E0A14 File Offset: 0x001DEC14
		public override void Write(Utf8JsonWriter writer, EClientEventFlyingFlowerEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
