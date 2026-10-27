using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001235 RID: 4661
	public class ECommonEventTypeJsonConverter : JsonConverter<ECommonEventType>
	{
		// Token: 0x06006997 RID: 27031 RVA: 0x000FCCC4 File Offset: 0x000FAEC4
		public override ECommonEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECommonEventType.VarValueChange;
			}
			return ECommonEventTypeExtensions.FromString(@string);
		}

		// Token: 0x06006998 RID: 27032 RVA: 0x000FCCE8 File Offset: 0x000FAEE8
		public override void Write(Utf8JsonWriter writer, ECommonEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
