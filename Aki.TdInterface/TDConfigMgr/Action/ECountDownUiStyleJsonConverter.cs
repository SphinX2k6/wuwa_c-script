using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002561 RID: 9569
	public class ECountDownUiStyleJsonConverter : JsonConverter<ECountDownUiStyle>
	{
		// Token: 0x0600CF90 RID: 53136 RVA: 0x001E161C File Offset: 0x001DF81C
		public override ECountDownUiStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECountDownUiStyle.Common;
			}
			return ECountDownUiStyleExtensions.FromString(@string);
		}

		// Token: 0x0600CF91 RID: 53137 RVA: 0x001E1640 File Offset: 0x001DF840
		public override void Write(Utf8JsonWriter writer, ECountDownUiStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
