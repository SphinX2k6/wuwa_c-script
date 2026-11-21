using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002547 RID: 9543
	public class EChangeTimerTypeJsonConverter : JsonConverter<EChangeTimerType>
	{
		// Token: 0x0600CF1B RID: 53019 RVA: 0x001E0800 File Offset: 0x001DEA00
		public override EChangeTimerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EChangeTimerType.Add;
			}
			return EChangeTimerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF1C RID: 53020 RVA: 0x001E0824 File Offset: 0x001DEA24
		public override void Write(Utf8JsonWriter writer, EChangeTimerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
