using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001375 RID: 4981
	public class EDarkTideModuleTypeJsonConverter : JsonConverter<EDarkTideModuleType>
	{
		// Token: 0x06006FEA RID: 28650 RVA: 0x0010A890 File Offset: 0x00108A90
		public override EDarkTideModuleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDarkTideModuleType.BossEvent;
			}
			return EDarkTideModuleTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FEB RID: 28651 RVA: 0x0010A8B4 File Offset: 0x00108AB4
		public override void Write(Utf8JsonWriter writer, EDarkTideModuleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
