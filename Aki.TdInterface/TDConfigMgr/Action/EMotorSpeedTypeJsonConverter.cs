using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002398 RID: 9112
	public class EMotorSpeedTypeJsonConverter : JsonConverter<EMotorSpeedType>
	{
		// Token: 0x0600C6AC RID: 50860 RVA: 0x001D187C File Offset: 0x001CFA7C
		public override EMotorSpeedType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorSpeedType.TargetSpeed;
			}
			return EMotorSpeedTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6AD RID: 50861 RVA: 0x001D18A0 File Offset: 0x001CFAA0
		public override void Write(Utf8JsonWriter writer, EMotorSpeedType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
