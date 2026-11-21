using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200265D RID: 9821
	public class EPhoneSystemInteractTypeJsonConverter : JsonConverter<EPhoneSystemInteractType>
	{
		// Token: 0x0600D3FE RID: 54270 RVA: 0x001ECBDC File Offset: 0x001EADDC
		public override EPhoneSystemInteractType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhoneSystemInteractType.SendPhoneMessage;
			}
			return EPhoneSystemInteractTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D3FF RID: 54271 RVA: 0x001ECC00 File Offset: 0x001EAE00
		public override void Write(Utf8JsonWriter writer, EPhoneSystemInteractType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
