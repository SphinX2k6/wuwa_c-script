using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002302 RID: 8962
	public class EDetectBattleTagTypeJsonConverter : JsonConverter<EDetectBattleTagType>
	{
		// Token: 0x0600C409 RID: 50185 RVA: 0x001C9FA8 File Offset: 0x001C81A8
		public override EDetectBattleTagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectBattleTagType.MonsterOnTheGround;
			}
			return EDetectBattleTagTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C40A RID: 50186 RVA: 0x001C9FCC File Offset: 0x001C81CC
		public override void Write(Utf8JsonWriter writer, EDetectBattleTagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
