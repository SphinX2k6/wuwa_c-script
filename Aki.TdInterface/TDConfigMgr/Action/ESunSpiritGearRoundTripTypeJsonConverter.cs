using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002440 RID: 9280
	public class ESunSpiritGearRoundTripTypeJsonConverter : JsonConverter<ESunSpiritGearRoundTripType>
	{
		// Token: 0x0600C9A0 RID: 51616 RVA: 0x001D84FC File Offset: 0x001D66FC
		public override ESunSpiritGearRoundTripType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESunSpiritGearRoundTripType.FlyToGear;
			}
			return ESunSpiritGearRoundTripTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9A1 RID: 51617 RVA: 0x001D8520 File Offset: 0x001D6720
		public override void Write(Utf8JsonWriter writer, ESunSpiritGearRoundTripType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
