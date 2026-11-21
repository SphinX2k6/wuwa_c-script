using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F7 RID: 5111
	public class ETrapDefenseConditionStepJsonConverter : JsonConverter<ETrapDefenseConditionStep>
	{
		// Token: 0x06007233 RID: 29235 RVA: 0x001114CC File Offset: 0x0010F6CC
		public override ETrapDefenseConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefenseConditionStep.Reward;
			}
			return ETrapDefenseConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06007234 RID: 29236 RVA: 0x001114F0 File Offset: 0x0010F6F0
		public override void Write(Utf8JsonWriter writer, ETrapDefenseConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
