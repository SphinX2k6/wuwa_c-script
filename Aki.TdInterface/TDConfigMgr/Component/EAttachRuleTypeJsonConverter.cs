using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099E RID: 2462
	public class EAttachRuleTypeJsonConverter : JsonConverter<EAttachRuleType>
	{
		// Token: 0x0600375B RID: 14171 RVA: 0x0008C738 File Offset: 0x0008A938
		public override EAttachRuleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAttachRuleType.Relatively;
			}
			return EAttachRuleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600375C RID: 14172 RVA: 0x0008C75C File Offset: 0x0008A95C
		public override void Write(Utf8JsonWriter writer, EAttachRuleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
