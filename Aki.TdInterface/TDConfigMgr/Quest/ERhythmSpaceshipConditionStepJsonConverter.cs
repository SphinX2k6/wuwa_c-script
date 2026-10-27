using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200127D RID: 4733
	public class ERhythmSpaceshipConditionStepJsonConverter : JsonConverter<ERhythmSpaceshipConditionStep>
	{
		// Token: 0x06006ADB RID: 27355 RVA: 0x001003AC File Offset: 0x000FE5AC
		public override ERhythmSpaceshipConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERhythmSpaceshipConditionStep.Interact;
			}
			return ERhythmSpaceshipConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06006ADC RID: 27356 RVA: 0x001003D0 File Offset: 0x000FE5D0
		public override void Write(Utf8JsonWriter writer, ERhythmSpaceshipConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
