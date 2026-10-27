using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200244C RID: 9292
	public class ESystemOptionTypeJsonConverter : JsonConverter<ESystemOptionType>
	{
		// Token: 0x0600C9D6 RID: 51670 RVA: 0x001D8B54 File Offset: 0x001D6D54
		public override ESystemOptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemOptionType.RogueRandomEvent;
			}
			return ESystemOptionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9D7 RID: 51671 RVA: 0x001D8B78 File Offset: 0x001D6D78
		public override void Write(Utf8JsonWriter writer, ESystemOptionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
