using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001277 RID: 4727
	public class ERecallConditionTypeJsonConverter : JsonConverter<ERecallConditionType>
	{
		// Token: 0x06006AC0 RID: 27328 RVA: 0x001000A8 File Offset: 0x000FE2A8
		public override ERecallConditionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERecallConditionType.ByEntityType;
			}
			return ERecallConditionTypeExtensions.FromString(@string);
		}

		// Token: 0x06006AC1 RID: 27329 RVA: 0x001000CC File Offset: 0x000FE2CC
		public override void Write(Utf8JsonWriter writer, ERecallConditionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
