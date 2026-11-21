using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002711 RID: 10001
	public class ETimeLimitOptionGroupStyleJsonConverter : JsonConverter<ETimeLimitOptionGroupStyle>
	{
		// Token: 0x0600D728 RID: 55080 RVA: 0x001F6DFC File Offset: 0x001F4FFC
		public override ETimeLimitOptionGroupStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeLimitOptionGroupStyle.Default;
			}
			return ETimeLimitOptionGroupStyleExtensions.FromString(@string);
		}

		// Token: 0x0600D729 RID: 55081 RVA: 0x001F6E20 File Offset: 0x001F5020
		public override void Write(Utf8JsonWriter writer, ETimeLimitOptionGroupStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
