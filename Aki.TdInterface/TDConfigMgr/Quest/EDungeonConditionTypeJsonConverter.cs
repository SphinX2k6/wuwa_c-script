using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200123B RID: 4667
	public class EDungeonConditionTypeJsonConverter : JsonConverter<EDungeonConditionType>
	{
		// Token: 0x060069B2 RID: 27058 RVA: 0x000FD190 File Offset: 0x000FB390
		public override EDungeonConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDungeonConditionType.DungeonSubType;
			}
			return EDungeonConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x060069B3 RID: 27059 RVA: 0x000FD1B4 File Offset: 0x000FB3B4
		public override void Write(Utf8JsonWriter writer, EDungeonConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
