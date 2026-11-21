using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002559 RID: 9561
	public class EClientSetSeasonStateTypeJsonConverter : JsonConverter<EClientSetSeasonStateType>
	{
		// Token: 0x0600CF6C RID: 53100 RVA: 0x001E1188 File Offset: 0x001DF388
		public override EClientSetSeasonStateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EClientSetSeasonStateType.SwitchSeason;
			}
			return EClientSetSeasonStateTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CF6D RID: 53101 RVA: 0x001E11AC File Offset: 0x001DF3AC
		public override void Write(Utf8JsonWriter writer, EClientSetSeasonStateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
