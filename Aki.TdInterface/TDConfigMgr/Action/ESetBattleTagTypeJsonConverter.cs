using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A3 RID: 9891
	public class ESetBattleTagTypeJsonConverter : JsonConverter<ESetBattleTagType>
	{
		// Token: 0x0600D539 RID: 54585 RVA: 0x001EF68C File Offset: 0x001ED88C
		public override ESetBattleTagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetBattleTagType.BattleMonsterLanding;
			}
			return ESetBattleTagTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D53A RID: 54586 RVA: 0x001EF6B0 File Offset: 0x001ED8B0
		public override void Write(Utf8JsonWriter writer, ESetBattleTagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
