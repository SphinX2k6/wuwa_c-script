using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002422 RID: 9250
	public class ESlideRailEndTypeJsonConverter : JsonConverter<ESlideRailEndType>
	{
		// Token: 0x0600C919 RID: 51481 RVA: 0x001D7300 File Offset: 0x001D5500
		public override ESlideRailEndType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlideRailEndType.Player;
			}
			return ESlideRailEndTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C91A RID: 51482 RVA: 0x001D7324 File Offset: 0x001D5524
		public override void Write(Utf8JsonWriter writer, ESlideRailEndType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
