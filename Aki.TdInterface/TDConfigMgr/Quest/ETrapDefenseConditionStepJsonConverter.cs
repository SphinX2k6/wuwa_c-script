using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B1 RID: 4785
	public class ETrapDefenseConditionStepJsonConverter : JsonConverter<ETrapDefenseConditionStep>
	{
		// Token: 0x06006BC5 RID: 27589 RVA: 0x00103504 File Offset: 0x00101704
		public override ETrapDefenseConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefenseConditionStep.Reward;
			}
			return ETrapDefenseConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06006BC6 RID: 27590 RVA: 0x00103528 File Offset: 0x00101728
		public override void Write(Utf8JsonWriter writer, ETrapDefenseConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
