using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002509 RID: 9481
	public class EAiEventTypeJsonConverter : JsonConverter<EAiEventType>
	{
		// Token: 0x0600CE04 RID: 52740 RVA: 0x001DDF2C File Offset: 0x001DC12C
		public override EAiEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAiEventType.CatAndDogPlayFlow;
			}
			return EAiEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CE05 RID: 52741 RVA: 0x001DDF50 File Offset: 0x001DC150
		public override void Write(Utf8JsonWriter writer, EAiEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
