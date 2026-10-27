using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A6 RID: 9126
	public class EMp4BackgroundColorJsonConverter : JsonConverter<EMp4BackgroundColor>
	{
		// Token: 0x0600C6EB RID: 50923 RVA: 0x001D20C0 File Offset: 0x001D02C0
		public override EMp4BackgroundColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMp4BackgroundColor.Black;
			}
			return EMp4BackgroundColorExtensions.FromString(@string);
		}

		// Token: 0x0600C6EC RID: 50924 RVA: 0x001D20E4 File Offset: 0x001D02E4
		public override void Write(Utf8JsonWriter writer, EMp4BackgroundColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
