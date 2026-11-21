using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001373 RID: 4979
	public class EDarkTideBossEventTypeJsonConverter : JsonConverter<EDarkTideBossEventType>
	{
		// Token: 0x06006FE1 RID: 28641 RVA: 0x0010A7B4 File Offset: 0x001089B4
		public override EDarkTideBossEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDarkTideBossEventType.XinjilemuChase;
			}
			return EDarkTideBossEventTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FE2 RID: 28642 RVA: 0x0010A7D8 File Offset: 0x001089D8
		public override void Write(Utf8JsonWriter writer, EDarkTideBossEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
