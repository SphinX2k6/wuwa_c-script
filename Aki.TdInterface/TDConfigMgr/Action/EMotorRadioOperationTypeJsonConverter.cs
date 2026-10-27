using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002396 RID: 9110
	public class EMotorRadioOperationTypeJsonConverter : JsonConverter<EMotorRadioOperationType>
	{
		// Token: 0x0600C6A3 RID: 50851 RVA: 0x001D17A0 File Offset: 0x001CF9A0
		public override EMotorRadioOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorRadioOperationType.EnableAll;
			}
			return EMotorRadioOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6A4 RID: 50852 RVA: 0x001D17C4 File Offset: 0x001CF9C4
		public override void Write(Utf8JsonWriter writer, EMotorRadioOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
