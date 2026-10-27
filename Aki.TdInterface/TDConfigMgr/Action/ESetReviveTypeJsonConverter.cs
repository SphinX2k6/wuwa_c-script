using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200240C RID: 9228
	public class ESetReviveTypeJsonConverter : JsonConverter<ESetReviveType>
	{
		// Token: 0x0600C8B6 RID: 51382 RVA: 0x001D5E70 File Offset: 0x001D4070
		public override ESetReviveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetReviveType.Add;
			}
			return ESetReviveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8B7 RID: 51383 RVA: 0x001D5E94 File Offset: 0x001D4094
		public override void Write(Utf8JsonWriter writer, ESetReviveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
