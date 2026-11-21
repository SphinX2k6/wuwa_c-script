using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F1 RID: 5105
	public class ETrackRuleTypeJsonConverter : JsonConverter<ETrackRuleType>
	{
		// Token: 0x06007218 RID: 29208 RVA: 0x00111048 File Offset: 0x0010F248
		public override ETrackRuleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackRuleType.FindLastMatchState;
			}
			return ETrackRuleTypeExtensions.FromString(@string);
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x0011106C File Offset: 0x0010F26C
		public override void Write(Utf8JsonWriter writer, ETrackRuleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
