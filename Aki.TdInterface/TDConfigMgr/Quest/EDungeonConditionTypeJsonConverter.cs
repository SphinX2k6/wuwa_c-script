using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200137B RID: 4987
	public class EDungeonConditionTypeJsonConverter : JsonConverter<EDungeonConditionType>
	{
		// Token: 0x06007005 RID: 28677 RVA: 0x0010AD5C File Offset: 0x00108F5C
		public override EDungeonConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDungeonConditionType.DungeonSubType;
			}
			return EDungeonConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x06007006 RID: 28678 RVA: 0x0010AD80 File Offset: 0x00108F80
		public override void Write(Utf8JsonWriter writer, EDungeonConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
