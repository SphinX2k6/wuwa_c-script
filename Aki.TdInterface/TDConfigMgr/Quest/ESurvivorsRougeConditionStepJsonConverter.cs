using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001297 RID: 4759
	public class ESurvivorsRougeConditionStepJsonConverter : JsonConverter<ESurvivorsRougeConditionStep>
	{
		// Token: 0x06006B50 RID: 27472 RVA: 0x00101C3C File Offset: 0x000FFE3C
		public override ESurvivorsRougeConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESurvivorsRougeConditionStep.Prepare;
			}
			return ESurvivorsRougeConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06006B51 RID: 27473 RVA: 0x00101C60 File Offset: 0x000FFE60
		public override void Write(Utf8JsonWriter writer, ESurvivorsRougeConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
