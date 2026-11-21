using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002659 RID: 9817
	public class EPhoneMessageTypeJsonConverter : JsonConverter<EPhoneMessageType>
	{
		// Token: 0x0600D3EC RID: 54252 RVA: 0x001EC940 File Offset: 0x001EAB40
		public override EPhoneMessageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneMessageType.Voice;
			}
			return EPhoneMessageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3ED RID: 54253 RVA: 0x001EC964 File Offset: 0x001EAB64
		public override void Write(Utf8JsonWriter writer, EPhoneMessageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
