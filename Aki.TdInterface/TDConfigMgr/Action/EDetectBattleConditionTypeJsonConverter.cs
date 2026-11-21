using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200256F RID: 9583
	public class EDetectBattleConditionTypeJsonConverter : JsonConverter<EDetectBattleConditionType>
	{
		// Token: 0x0600CFCF RID: 53199 RVA: 0x001E1D94 File Offset: 0x001DFF94
		public override EDetectBattleConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDetectBattleConditionType.DetectBattleTag;
			}
			return EDetectBattleConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CFD0 RID: 53200 RVA: 0x001E1DB8 File Offset: 0x001DFFB8
		public override void Write(Utf8JsonWriter writer, EDetectBattleConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
