using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200267B RID: 9851
	public class EQuestCommonTipTypeJsonConverter : JsonConverter<EQuestCommonTipType>
	{
		// Token: 0x0600D485 RID: 54405 RVA: 0x001EE060 File Offset: 0x001EC260
		public override EQuestCommonTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestCommonTipType.Branch;
			}
			return EQuestCommonTipTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D486 RID: 54406 RVA: 0x001EE084 File Offset: 0x001EC284
		public override void Write(Utf8JsonWriter writer, EQuestCommonTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
