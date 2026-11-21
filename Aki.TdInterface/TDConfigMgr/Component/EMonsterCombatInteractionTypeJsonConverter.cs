using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A54 RID: 2644
	public class EMonsterCombatInteractionTypeJsonConverter : JsonConverter<EMonsterCombatInteractionType>
	{
		// Token: 0x06003A8E RID: 14990 RVA: 0x0009716C File Offset: 0x0009536C
		public override EMonsterCombatInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterCombatInteractionType.WaterBoxStagnation;
			}
			return EMonsterCombatInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A8F RID: 14991 RVA: 0x00097190 File Offset: 0x00095390
		public override void Write(Utf8JsonWriter writer, EMonsterCombatInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
