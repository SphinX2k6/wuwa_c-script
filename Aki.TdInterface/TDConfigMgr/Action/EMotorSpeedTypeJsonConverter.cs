using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002623 RID: 9763
	public class EMotorSpeedTypeJsonConverter : JsonConverter<EMotorSpeedType>
	{
		// Token: 0x0600D2F9 RID: 54009 RVA: 0x001EAA1C File Offset: 0x001E8C1C
		public override EMotorSpeedType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorSpeedType.TargetSpeed;
			}
			return EMotorSpeedTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2FA RID: 54010 RVA: 0x001EAA40 File Offset: 0x001E8C40
		public override void Write(Utf8JsonWriter writer, EMotorSpeedType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
