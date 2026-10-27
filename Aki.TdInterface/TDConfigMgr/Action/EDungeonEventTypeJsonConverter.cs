using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200230A RID: 8970
	public class EDungeonEventTypeJsonConverter : JsonConverter<EDungeonEventType>
	{
		// Token: 0x0600C42D RID: 50221 RVA: 0x001CA478 File Offset: 0x001C8678
		public override EDungeonEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDungeonEventType.RecordTimeStamp;
			}
			return EDungeonEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C42E RID: 50222 RVA: 0x001CA49C File Offset: 0x001C869C
		public override void Write(Utf8JsonWriter writer, EDungeonEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
