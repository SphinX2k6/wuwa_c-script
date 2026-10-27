using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EE RID: 9198
	public class EResetPlayerFocusTypeJsonConverter : JsonConverter<EResetPlayerFocusType>
	{
		// Token: 0x0600C82F RID: 51247 RVA: 0x001D4E1C File Offset: 0x001D301C
		public override EResetPlayerFocusType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetPlayerFocusType.ResetToDefaultDirection;
			}
			return EResetPlayerFocusTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C830 RID: 51248 RVA: 0x001D4E40 File Offset: 0x001D3040
		public override void Write(Utf8JsonWriter writer, EResetPlayerFocusType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
