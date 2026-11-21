using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D9 RID: 5081
	public class ESurvivorsRougeConditionStepJsonConverter : JsonConverter<ESurvivorsRougeConditionStep>
	{
		// Token: 0x060071AC RID: 29100 RVA: 0x0010FA14 File Offset: 0x0010DC14
		public override ESurvivorsRougeConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESurvivorsRougeConditionStep.Prepare;
			}
			return ESurvivorsRougeConditionStepExtensions.FromString(@string);
		}

		// Token: 0x060071AD RID: 29101 RVA: 0x0010FA38 File Offset: 0x0010DC38
		public override void Write(Utf8JsonWriter writer, ESurvivorsRougeConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
