using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012AB RID: 4779
	public class ETrackRuleTypeJsonConverter : JsonConverter<ETrackRuleType>
	{
		// Token: 0x06006BAA RID: 27562 RVA: 0x00103080 File Offset: 0x00101280
		public override ETrackRuleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackRuleType.FindLastMatchState;
			}
			return ETrackRuleTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x001030A4 File Offset: 0x001012A4
		public override void Write(Utf8JsonWriter writer, ETrackRuleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
