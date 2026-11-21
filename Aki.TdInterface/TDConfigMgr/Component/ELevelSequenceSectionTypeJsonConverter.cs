using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A40 RID: 2624
	public class ELevelSequenceSectionTypeJsonConverter : JsonConverter<ELevelSequenceSectionType>
	{
		// Token: 0x06003A34 RID: 14900 RVA: 0x000965B0 File Offset: 0x000947B0
		public override ELevelSequenceSectionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelSequenceSectionType.Mark;
			}
			return ELevelSequenceSectionTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A35 RID: 14901 RVA: 0x000965D4 File Offset: 0x000947D4
		public override void Write(Utf8JsonWriter writer, ELevelSequenceSectionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
