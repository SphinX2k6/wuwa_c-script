using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023EC RID: 9196
	public class EResetEntityTypeJsonConverter : JsonConverter<EResetEntityType>
	{
		// Token: 0x0600C826 RID: 51238 RVA: 0x001D4D08 File Offset: 0x001D2F08
		public override EResetEntityType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EResetEntityType.TeleControl;
			}
			return EResetEntityTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C827 RID: 51239 RVA: 0x001D4D2C File Offset: 0x001D2F2C
		public override void Write(Utf8JsonWriter writer, EResetEntityType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
