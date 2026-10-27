using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002392 RID: 9106
	public class EMotorParamsChangeTypeJsonConverter : JsonConverter<EMotorParamsChangeType>
	{
		// Token: 0x0600C691 RID: 50833 RVA: 0x001D1534 File Offset: 0x001CF734
		public override EMotorParamsChangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorParamsChangeType.SpeedUp;
			}
			return EMotorParamsChangeTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C692 RID: 50834 RVA: 0x001D1558 File Offset: 0x001CF758
		public override void Write(Utf8JsonWriter writer, EMotorParamsChangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
