using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002621 RID: 9761
	public class EMotorRadioOperationTypeJsonConverter : JsonConverter<EMotorRadioOperationType>
	{
		// Token: 0x0600D2F0 RID: 54000 RVA: 0x001EA940 File Offset: 0x001E8B40
		public override EMotorRadioOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorRadioOperationType.EnableAll;
			}
			return EMotorRadioOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2F1 RID: 54001 RVA: 0x001EA964 File Offset: 0x001E8B64
		public override void Write(Utf8JsonWriter writer, EMotorRadioOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
