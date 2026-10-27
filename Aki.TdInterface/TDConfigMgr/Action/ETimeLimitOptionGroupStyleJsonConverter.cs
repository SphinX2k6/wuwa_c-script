using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002470 RID: 9328
	public class ETimeLimitOptionGroupStyleJsonConverter : JsonConverter<ETimeLimitOptionGroupStyle>
	{
		// Token: 0x0600CA78 RID: 51832 RVA: 0x001DCD48 File Offset: 0x001DAF48
		public override ETimeLimitOptionGroupStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETimeLimitOptionGroupStyle.Default;
			}
			return ETimeLimitOptionGroupStyleExtensions.FromString(@string);
		}

		// Token: 0x0600CA79 RID: 51833 RVA: 0x001DCD6C File Offset: 0x001DAF6C
		public override void Write(Utf8JsonWriter writer, ETimeLimitOptionGroupStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
