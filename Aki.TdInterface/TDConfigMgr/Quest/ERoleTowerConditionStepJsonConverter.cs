using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001283 RID: 4739
	public class ERoleTowerConditionStepJsonConverter : JsonConverter<ERoleTowerConditionStep>
	{
		// Token: 0x06006AF6 RID: 27382 RVA: 0x00100A2C File Offset: 0x000FEC2C
		public override ERoleTowerConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleTowerConditionStep.Prepare;
			}
			return ERoleTowerConditionStepExtensions.FromString(@string);
		}

		// Token: 0x06006AF7 RID: 27383 RVA: 0x00100A50 File Offset: 0x000FEC50
		public override void Write(Utf8JsonWriter writer, ERoleTowerConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
