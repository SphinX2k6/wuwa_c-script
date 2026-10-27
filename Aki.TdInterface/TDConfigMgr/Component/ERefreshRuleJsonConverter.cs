using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F1 RID: 2545
	public class ERefreshRuleJsonConverter : JsonConverter<ERefreshRule>
	{
		// Token: 0x0600386F RID: 14447 RVA: 0x00092240 File Offset: 0x00090440
		public override ERefreshRule Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERefreshRule.CD;
			}
			return ERefreshRuleExtensions.FromString(@string);
		}

		// Token: 0x06003870 RID: 14448 RVA: 0x00092264 File Offset: 0x00090464
		public override void Write(Utf8JsonWriter writer, ERefreshRule value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
