using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E4 RID: 9188
	public class EQuestCommonTipTypeJsonConverter : JsonConverter<EQuestCommonTipType>
	{
		// Token: 0x0600C802 RID: 51202 RVA: 0x001D48B4 File Offset: 0x001D2AB4
		public override EQuestCommonTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestCommonTipType.Branch;
			}
			return EQuestCommonTipTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C803 RID: 51203 RVA: 0x001D48D8 File Offset: 0x001D2AD8
		public override void Write(Utf8JsonWriter writer, EQuestCommonTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
