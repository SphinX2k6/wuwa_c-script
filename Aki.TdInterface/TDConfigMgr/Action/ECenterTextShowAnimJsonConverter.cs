using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022D0 RID: 8912
	public class ECenterTextShowAnimJsonConverter : JsonConverter<ECenterTextShowAnim>
	{
		// Token: 0x0600C328 RID: 49960 RVA: 0x001C8520 File Offset: 0x001C6720
		public override ECenterTextShowAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECenterTextShowAnim.ShowAll;
			}
			return ECenterTextShowAnimExtensions.FromString(@string);
		}

		// Token: 0x0600C329 RID: 49961 RVA: 0x001C8544 File Offset: 0x001C6744
		public override void Write(Utf8JsonWriter writer, ECenterTextShowAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
