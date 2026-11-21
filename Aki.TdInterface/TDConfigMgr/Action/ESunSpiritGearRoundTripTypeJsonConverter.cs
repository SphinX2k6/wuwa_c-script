using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E1 RID: 9953
	public class ESunSpiritGearRoundTripTypeJsonConverter : JsonConverter<ESunSpiritGearRoundTripType>
	{
		// Token: 0x0600D650 RID: 54864 RVA: 0x001F23C4 File Offset: 0x001F05C4
		public override ESunSpiritGearRoundTripType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESunSpiritGearRoundTripType.FlyToGear;
			}
			return ESunSpiritGearRoundTripTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D651 RID: 54865 RVA: 0x001F23E8 File Offset: 0x001F05E8
		public override void Write(Utf8JsonWriter writer, ESunSpiritGearRoundTripType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
