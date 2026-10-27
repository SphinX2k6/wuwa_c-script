using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098D RID: 2445
	public class ELevelSequenceSectionTypeJsonConverter : JsonConverter<ELevelSequenceSectionType>
	{
		// Token: 0x060036AD RID: 13997 RVA: 0x0008E644 File Offset: 0x0008C844
		public override ELevelSequenceSectionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelSequenceSectionType.Mark;
			}
			return ELevelSequenceSectionTypeExtensions.FromString(@string);
		}

		// Token: 0x060036AE RID: 13998 RVA: 0x0008E668 File Offset: 0x0008C868
		public override void Write(Utf8JsonWriter writer, ELevelSequenceSectionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
