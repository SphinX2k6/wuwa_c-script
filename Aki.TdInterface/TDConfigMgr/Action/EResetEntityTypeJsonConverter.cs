using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002683 RID: 9859
	public class EResetEntityTypeJsonConverter : JsonConverter<EResetEntityType>
	{
		// Token: 0x0600D4A9 RID: 54441 RVA: 0x001EE4B4 File Offset: 0x001EC6B4
		public override EResetEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetEntityType.TeleControl;
			}
			return EResetEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4AA RID: 54442 RVA: 0x001EE4D8 File Offset: 0x001EC6D8
		public override void Write(Utf8JsonWriter writer, EResetEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
