using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C4 RID: 9156
	public class EPhoneMessageTypeJsonConverter : JsonConverter<EPhoneMessageType>
	{
		// Token: 0x0600C772 RID: 51058 RVA: 0x001D32A8 File Offset: 0x001D14A8
		public override EPhoneMessageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneMessageType.Voice;
			}
			return EPhoneMessageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C773 RID: 51059 RVA: 0x001D32CC File Offset: 0x001D14CC
		public override void Write(Utf8JsonWriter writer, EPhoneMessageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
