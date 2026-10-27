using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022DE RID: 8926
	public class EClientEventPianoEventTypeJsonConverter : JsonConverter<EClientEventPianoEventType>
	{
		// Token: 0x0600C367 RID: 50023 RVA: 0x001C8CFC File Offset: 0x001C6EFC
		public override EClientEventPianoEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientEventPianoEventType.UpdateSubtitle;
			}
			return EClientEventPianoEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C368 RID: 50024 RVA: 0x001C8D20 File Offset: 0x001C6F20
		public override void Write(Utf8JsonWriter writer, EClientEventPianoEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
