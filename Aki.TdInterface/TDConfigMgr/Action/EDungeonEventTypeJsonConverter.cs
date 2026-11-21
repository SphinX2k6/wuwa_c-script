using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002579 RID: 9593
	public class EDungeonEventTypeJsonConverter : JsonConverter<EDungeonEventType>
	{
		// Token: 0x0600CFFC RID: 53244 RVA: 0x001E2340 File Offset: 0x001E0540
		public override EDungeonEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDungeonEventType.RecordTimeStamp;
			}
			return EDungeonEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFFD RID: 53245 RVA: 0x001E2364 File Offset: 0x001E0564
		public override void Write(Utf8JsonWriter writer, EDungeonEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
