using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001371 RID: 4977
	public class ECommonEventTypeJsonConverter : JsonConverter<ECommonEventType>
	{
		// Token: 0x06006FD8 RID: 28632 RVA: 0x0010A5D0 File Offset: 0x001087D0
		public override ECommonEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECommonEventType.VarValueChange;
			}
			return ECommonEventTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FD9 RID: 28633 RVA: 0x0010A5F4 File Offset: 0x001087F4
		public override void Write(Utf8JsonWriter writer, ECommonEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
