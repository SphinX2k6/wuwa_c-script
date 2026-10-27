using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F5 RID: 2293
	public class EAttachRuleTypeJsonConverter : JsonConverter<EAttachRuleType>
	{
		// Token: 0x06003401 RID: 13313 RVA: 0x00084F0C File Offset: 0x0008310C
		public override EAttachRuleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachRuleType.Relatively;
			}
			return EAttachRuleTypeExtensions.FromString(@string);
		}

		// Token: 0x06003402 RID: 13314 RVA: 0x00084F30 File Offset: 0x00083130
		public override void Write(Utf8JsonWriter writer, EAttachRuleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
