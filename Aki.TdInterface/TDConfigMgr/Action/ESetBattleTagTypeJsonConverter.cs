using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002404 RID: 9220
	public class ESetBattleTagTypeJsonConverter : JsonConverter<ESetBattleTagType>
	{
		// Token: 0x0600C892 RID: 51346 RVA: 0x001D5A90 File Offset: 0x001D3C90
		public override ESetBattleTagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetBattleTagType.BattleMonsterLanding;
			}
			return ESetBattleTagTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C893 RID: 51347 RVA: 0x001D5AB4 File Offset: 0x001D3CB4
		public override void Write(Utf8JsonWriter writer, ESetBattleTagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
