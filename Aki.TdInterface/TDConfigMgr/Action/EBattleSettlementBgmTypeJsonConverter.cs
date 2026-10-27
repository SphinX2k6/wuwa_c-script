using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B8 RID: 8888
	public class EBattleSettlementBgmTypeJsonConverter : JsonConverter<EBattleSettlementBgmType>
	{
		// Token: 0x0600C2BC RID: 49852 RVA: 0x001C7444 File Offset: 0x001C5644
		public override EBattleSettlementBgmType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBattleSettlementBgmType.BattleSoundWave;
			}
			return EBattleSettlementBgmTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C2BD RID: 49853 RVA: 0x001C7468 File Offset: 0x001C5668
		public override void Write(Utf8JsonWriter writer, EBattleSettlementBgmType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
