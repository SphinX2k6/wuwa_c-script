using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023C8 RID: 9160
	public class EPhoneSystemInteractTypeJsonConverter : JsonConverter<EPhoneSystemInteractType>
	{
		// Token: 0x0600C784 RID: 51076 RVA: 0x001D3544 File Offset: 0x001D1744
		public override EPhoneSystemInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneSystemInteractType.SendPhoneMessage;
			}
			return EPhoneSystemInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C785 RID: 51077 RVA: 0x001D3568 File Offset: 0x001D1768
		public override void Write(Utf8JsonWriter writer, EPhoneSystemInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
