using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001243 RID: 4675
	public class EFlipperConditionStepJsonConverter : JsonConverter<EFlipperConditionStep>
	{
		// Token: 0x060069D6 RID: 27094 RVA: 0x000FD8EC File Offset: 0x000FBAEC
		public override EFlipperConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlipperConditionStep.Fight;
			}
			return EFlipperConditionStepExtensions.FromString(@string);
		}

		// Token: 0x060069D7 RID: 27095 RVA: 0x000FD910 File Offset: 0x000FBB10
		public override void Write(Utf8JsonWriter writer, EFlipperConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
