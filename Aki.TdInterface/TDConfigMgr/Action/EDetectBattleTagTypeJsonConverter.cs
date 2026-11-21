using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002571 RID: 9585
	public class EDetectBattleTagTypeJsonConverter : JsonConverter<EDetectBattleTagType>
	{
		// Token: 0x0600CFD8 RID: 53208 RVA: 0x001E1E70 File Offset: 0x001E0070
		public override EDetectBattleTagType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectBattleTagType.MonsterOnTheGround;
			}
			return EDetectBattleTagTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFD9 RID: 53209 RVA: 0x001E1E94 File Offset: 0x001E0094
		public override void Write(Utf8JsonWriter writer, EDetectBattleTagType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
