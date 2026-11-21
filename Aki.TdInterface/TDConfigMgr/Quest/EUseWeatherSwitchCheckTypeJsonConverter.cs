using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013FD RID: 5117
	public class EUseWeatherSwitchCheckTypeJsonConverter : JsonConverter<EUseWeatherSwitchCheckType>
	{
		// Token: 0x0600724E RID: 29262 RVA: 0x00111A88 File Offset: 0x0010FC88
		public override EUseWeatherSwitchCheckType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUseWeatherSwitchCheckType.SpecifiedWeather;
			}
			return EUseWeatherSwitchCheckTypeExtensions.FromString(@string);
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x00111AAC File Offset: 0x0010FCAC
		public override void Write(Utf8JsonWriter writer, EUseWeatherSwitchCheckType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
