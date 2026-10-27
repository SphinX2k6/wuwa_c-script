using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A4 RID: 8868
	public class EAssistCharacterMoveTypeJsonConverter : JsonConverter<EAssistCharacterMoveType>
	{
		// Token: 0x0600C262 RID: 49762 RVA: 0x001C66C4 File Offset: 0x001C48C4
		public override EAssistCharacterMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAssistCharacterMoveType.Navigation;
			}
			return EAssistCharacterMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C263 RID: 49763 RVA: 0x001C66E8 File Offset: 0x001C48E8
		public override void Write(Utf8JsonWriter writer, EAssistCharacterMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
