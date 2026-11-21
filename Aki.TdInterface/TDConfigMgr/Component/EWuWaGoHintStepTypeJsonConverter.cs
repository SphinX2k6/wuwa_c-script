using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B16 RID: 2838
	public class EWuWaGoHintStepTypeJsonConverter : JsonConverter<EWuWaGoHintStepType>
	{
		// Token: 0x06003DF7 RID: 15863 RVA: 0x0009E8F0 File Offset: 0x0009CAF0
		public override EWuWaGoHintStepType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoHintStepType.Move;
			}
			return EWuWaGoHintStepTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DF8 RID: 15864 RVA: 0x0009E914 File Offset: 0x0009CB14
		public override void Write(Utf8JsonWriter writer, EWuWaGoHintStepType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
