using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002713 RID: 10003
	public class ETimerTypeJsonConverter : JsonConverter<ETimerType>
	{
		// Token: 0x0600D731 RID: 55089 RVA: 0x001F70F8 File Offset: 0x001F52F8
		public override ETimerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimerType.CountDownChallenge;
			}
			return ETimerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D732 RID: 55090 RVA: 0x001F711C File Offset: 0x001F531C
		public override void Write(Utf8JsonWriter writer, ETimerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
