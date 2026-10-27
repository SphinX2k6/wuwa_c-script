using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200229C RID: 8860
	public class EAiEventTypeJsonConverter : JsonConverter<EAiEventType>
	{
		// Token: 0x0600C23E RID: 49726 RVA: 0x001C6238 File Offset: 0x001C4438
		public override EAiEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAiEventType.CatAndDogPlayFlow;
			}
			return EAiEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C23F RID: 49727 RVA: 0x001C625C File Offset: 0x001C445C
		public override void Write(Utf8JsonWriter writer, EAiEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
