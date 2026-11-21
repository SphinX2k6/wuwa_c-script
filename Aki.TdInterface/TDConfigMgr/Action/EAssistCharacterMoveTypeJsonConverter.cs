using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002513 RID: 9491
	public class EAssistCharacterMoveTypeJsonConverter : JsonConverter<EAssistCharacterMoveType>
	{
		// Token: 0x0600CE31 RID: 52785 RVA: 0x001DE4CC File Offset: 0x001DC6CC
		public override EAssistCharacterMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAssistCharacterMoveType.Navigation;
			}
			return EAssistCharacterMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE32 RID: 52786 RVA: 0x001DE4F0 File Offset: 0x001DC6F0
		public override void Write(Utf8JsonWriter writer, EAssistCharacterMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
