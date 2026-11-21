using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013E5 RID: 5093
	public class ETargetBattleAttributeJsonConverter : JsonConverter<ETargetBattleAttribute>
	{
		// Token: 0x060071E2 RID: 29154 RVA: 0x00110298 File Offset: 0x0010E498
		public override ETargetBattleAttribute Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetBattleAttribute.Player;
			}
			return ETargetBattleAttributeExtensions.FromString(@string);
		}

		// Token: 0x060071E3 RID: 29155 RVA: 0x001102BC File Offset: 0x0010E4BC
		public override void Write(Utf8JsonWriter writer, ETargetBattleAttribute value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
