using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200253F RID: 9535
	public class ECenterTextShowAnimJsonConverter : JsonConverter<ECenterTextShowAnim>
	{
		// Token: 0x0600CEF7 RID: 52983 RVA: 0x001E0328 File Offset: 0x001DE528
		public override ECenterTextShowAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECenterTextShowAnim.ShowAll;
			}
			return ECenterTextShowAnimExtensions.FromString(@string);
		}

		// Token: 0x0600CEF8 RID: 52984 RVA: 0x001E034C File Offset: 0x001DE54C
		public override void Write(Utf8JsonWriter writer, ECenterTextShowAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
