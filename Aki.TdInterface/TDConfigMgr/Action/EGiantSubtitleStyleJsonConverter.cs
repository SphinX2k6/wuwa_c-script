using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025BD RID: 9661
	public class EGiantSubtitleStyleJsonConverter : JsonConverter<EGiantSubtitleStyle>
	{
		// Token: 0x0600D12E RID: 53550 RVA: 0x001E4EA4 File Offset: 0x001E30A4
		public override EGiantSubtitleStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGiantSubtitleStyle.Neutral;
			}
			return EGiantSubtitleStyleExtensions.FromString(@string);
		}

		// Token: 0x0600D12F RID: 53551 RVA: 0x001E4EC8 File Offset: 0x001E30C8
		public override void Write(Utf8JsonWriter writer, EGiantSubtitleStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
