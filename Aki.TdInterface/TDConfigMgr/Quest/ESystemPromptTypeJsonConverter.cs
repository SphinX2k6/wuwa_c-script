using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013DD RID: 5085
	public class ESystemPromptTypeJsonConverter : JsonConverter<ESystemPromptType>
	{
		// Token: 0x060071BE RID: 29118 RVA: 0x0010FE0C File Offset: 0x0010E00C
		public override ESystemPromptType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemPromptType.AreaName;
			}
			return ESystemPromptTypeExtensions.FromString(@string);
		}

		// Token: 0x060071BF RID: 29119 RVA: 0x0010FE30 File Offset: 0x0010E030
		public override void Write(Utf8JsonWriter writer, ESystemPromptType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
