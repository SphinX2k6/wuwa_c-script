using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013BD RID: 5053
	public class ERhythmSpaceshipConditionStepJsonConverter : JsonConverter<ERhythmSpaceshipConditionStep>
	{
		// Token: 0x0600712E RID: 28974 RVA: 0x0010DFD8 File Offset: 0x0010C1D8
		public override ERhythmSpaceshipConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERhythmSpaceshipConditionStep.Interact;
			}
			return ERhythmSpaceshipConditionStepExtensions.FromString(@string);
		}

		// Token: 0x0600712F RID: 28975 RVA: 0x0010DFFC File Offset: 0x0010C1FC
		public override void Write(Utf8JsonWriter writer, ERhythmSpaceshipConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
