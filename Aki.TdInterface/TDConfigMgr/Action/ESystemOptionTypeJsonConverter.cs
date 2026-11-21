using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026ED RID: 9965
	public class ESystemOptionTypeJsonConverter : JsonConverter<ESystemOptionType>
	{
		// Token: 0x0600D686 RID: 54918 RVA: 0x001F2A4C File Offset: 0x001F0C4C
		public override ESystemOptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESystemOptionType.RogueRandomEvent;
			}
			return ESystemOptionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D687 RID: 54919 RVA: 0x001F2A70 File Offset: 0x001F0C70
		public override void Write(Utf8JsonWriter writer, ESystemOptionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
