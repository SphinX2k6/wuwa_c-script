using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200261F RID: 9759
	public class EMotorRadioDisableRangeTypeJsonConverter : JsonConverter<EMotorRadioDisableRangeType>
	{
		// Token: 0x0600D2E7 RID: 53991 RVA: 0x001EA7B8 File Offset: 0x001E89B8
		public override EMotorRadioDisableRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorRadioDisableRangeType.ByAreaId;
			}
			return EMotorRadioDisableRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2E8 RID: 53992 RVA: 0x001EA7DC File Offset: 0x001E89DC
		public override void Write(Utf8JsonWriter writer, EMotorRadioDisableRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
