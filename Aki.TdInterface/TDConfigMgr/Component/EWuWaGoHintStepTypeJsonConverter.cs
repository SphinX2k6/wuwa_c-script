using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4D RID: 2637
	public class EWuWaGoHintStepTypeJsonConverter : JsonConverter<EWuWaGoHintStepType>
	{
		// Token: 0x06003A0D RID: 14861 RVA: 0x00095D20 File Offset: 0x00093F20
		public override EWuWaGoHintStepType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoHintStepType.Move;
			}
			return EWuWaGoHintStepTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A0E RID: 14862 RVA: 0x00095D44 File Offset: 0x00093F44
		public override void Write(Utf8JsonWriter writer, EWuWaGoHintStepType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
