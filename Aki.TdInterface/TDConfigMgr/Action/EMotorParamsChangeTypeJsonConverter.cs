using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200261B RID: 9755
	public class EMotorParamsChangeTypeJsonConverter : JsonConverter<EMotorParamsChangeType>
	{
		// Token: 0x0600D2D5 RID: 53973 RVA: 0x001EA508 File Offset: 0x001E8708
		public override EMotorParamsChangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorParamsChangeType.SpeedUp;
			}
			return EMotorParamsChangeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2D6 RID: 53974 RVA: 0x001EA52C File Offset: 0x001E872C
		public override void Write(Utf8JsonWriter writer, EMotorParamsChangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
