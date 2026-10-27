using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B7 RID: 4791
	public class EUseWeatherSwitchCheckTypeJsonConverter : JsonConverter<EUseWeatherSwitchCheckType>
	{
		// Token: 0x06006BE0 RID: 27616 RVA: 0x00103AC0 File Offset: 0x00101CC0
		public override EUseWeatherSwitchCheckType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUseWeatherSwitchCheckType.SpecifiedWeather;
			}
			return EUseWeatherSwitchCheckTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BE1 RID: 27617 RVA: 0x00103AE4 File Offset: 0x00101CE4
		public override void Write(Utf8JsonWriter writer, EUseWeatherSwitchCheckType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
