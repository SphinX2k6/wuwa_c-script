using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002685 RID: 9861
	public class EResetPlayerFocusTypeJsonConverter : JsonConverter<EResetPlayerFocusType>
	{
		// Token: 0x0600D4B2 RID: 54450 RVA: 0x001EE5C8 File Offset: 0x001EC7C8
		public override EResetPlayerFocusType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetPlayerFocusType.ResetToDefaultDirection;
			}
			return EResetPlayerFocusTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4B3 RID: 54451 RVA: 0x001EE5EC File Offset: 0x001EC7EC
		public override void Write(Utf8JsonWriter writer, EResetPlayerFocusType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
