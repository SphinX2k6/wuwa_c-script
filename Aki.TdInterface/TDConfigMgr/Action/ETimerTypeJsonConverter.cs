using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002472 RID: 9330
	public class ETimerTypeJsonConverter : JsonConverter<ETimerType>
	{
		// Token: 0x0600CA81 RID: 51841 RVA: 0x001DD044 File Offset: 0x001DB244
		public override ETimerType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimerType.CountDownChallenge;
			}
			return ETimerTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CA82 RID: 51842 RVA: 0x001DD068 File Offset: 0x001DB268
		public override void Write(Utf8JsonWriter writer, ETimerType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
