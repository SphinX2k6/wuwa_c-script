using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002300 RID: 8960
	public class EDetectBattleConditionTypeJsonConverter : JsonConverter<EDetectBattleConditionType>
	{
		// Token: 0x0600C400 RID: 50176 RVA: 0x001C9ECC File Offset: 0x001C80CC
		public override EDetectBattleConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectBattleConditionType.DetectBattleTag;
			}
			return EDetectBattleConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C401 RID: 50177 RVA: 0x001C9EF0 File Offset: 0x001C80F0
		public override void Write(Utf8JsonWriter writer, EDetectBattleConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
