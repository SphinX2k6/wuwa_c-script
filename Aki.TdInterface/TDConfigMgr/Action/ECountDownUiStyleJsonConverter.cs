using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022F2 RID: 8946
	public class ECountDownUiStyleJsonConverter : JsonConverter<ECountDownUiStyle>
	{
		// Token: 0x0600C3C1 RID: 50113 RVA: 0x001C97D0 File Offset: 0x001C79D0
		public override ECountDownUiStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECountDownUiStyle.Common;
			}
			return ECountDownUiStyleExtensions.FromString(@string);
		}

		// Token: 0x0600C3C2 RID: 50114 RVA: 0x001C97F4 File Offset: 0x001C79F4
		public override void Write(Utf8JsonWriter writer, ECountDownUiStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
