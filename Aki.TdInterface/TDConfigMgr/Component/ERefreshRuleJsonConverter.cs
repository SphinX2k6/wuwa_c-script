using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB6 RID: 2742
	public class ERefreshRuleJsonConverter : JsonConverter<ERefreshRule>
	{
		// Token: 0x06003C47 RID: 15431 RVA: 0x0009AB00 File Offset: 0x00098D00
		public override ERefreshRule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERefreshRule.CD;
			}
			return ERefreshRuleExtensions.FromString(@string);
		}

		// Token: 0x06003C48 RID: 15432 RVA: 0x0009AB24 File Offset: 0x00098D24
		public override void Write(Utf8JsonWriter writer, ERefreshRule value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
