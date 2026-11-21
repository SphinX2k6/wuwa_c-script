using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001383 RID: 4995
	public class EFlipperConditionStepJsonConverter : JsonConverter<EFlipperConditionStep>
	{
		// Token: 0x06007029 RID: 28713 RVA: 0x0010B518 File Offset: 0x00109718
		public override EFlipperConditionStep Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFlipperConditionStep.Fight;
			}
			return EFlipperConditionStepExtensions.FromString(@string);
		}

		// Token: 0x0600702A RID: 28714 RVA: 0x0010B53C File Offset: 0x0010973C
		public override void Write(Utf8JsonWriter writer, EFlipperConditionStep value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
