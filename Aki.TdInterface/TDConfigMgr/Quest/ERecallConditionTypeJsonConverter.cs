using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B7 RID: 5047
	public class ERecallConditionTypeJsonConverter : JsonConverter<ERecallConditionType>
	{
		// Token: 0x06007113 RID: 28947 RVA: 0x0010DCD4 File Offset: 0x0010BED4
		public override ERecallConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERecallConditionType.ByEntityType;
			}
			return ERecallConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x06007114 RID: 28948 RVA: 0x0010DCF8 File Offset: 0x0010BEF8
		public override void Write(Utf8JsonWriter writer, ERecallConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
