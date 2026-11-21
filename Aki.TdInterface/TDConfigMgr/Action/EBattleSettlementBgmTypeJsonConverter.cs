using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002527 RID: 9511
	public class EBattleSettlementBgmTypeJsonConverter : JsonConverter<EBattleSettlementBgmType>
	{
		// Token: 0x0600CE8B RID: 52875 RVA: 0x001DF24C File Offset: 0x001DD44C
		public override EBattleSettlementBgmType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBattleSettlementBgmType.BattleSoundWave;
			}
			return EBattleSettlementBgmTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE8C RID: 52876 RVA: 0x001DF270 File Offset: 0x001DD470
		public override void Write(Utf8JsonWriter writer, EBattleSettlementBgmType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
