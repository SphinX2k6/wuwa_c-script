using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C3 RID: 5059
	public class ERoleTowerConditionStepJsonConverter : JsonConverter<ERoleTowerConditionStep>
	{
		// Token: 0x06007149 RID: 29001 RVA: 0x0010E658 File Offset: 0x0010C858
		public override ERoleTowerConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoleTowerConditionStep.Prepare;
			}
			return ERoleTowerConditionStepExtensions.FromString(@string);
		}

		// Token: 0x0600714A RID: 29002 RVA: 0x0010E67C File Offset: 0x0010C87C
		public override void Write(Utf8JsonWriter writer, ERoleTowerConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
