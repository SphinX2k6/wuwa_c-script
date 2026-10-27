using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200234A RID: 9034
	public class EGiantSubtitleStyleJsonConverter : JsonConverter<EGiantSubtitleStyle>
	{
		// Token: 0x0600C54D RID: 50509 RVA: 0x001CCCD8 File Offset: 0x001CAED8
		public override EGiantSubtitleStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGiantSubtitleStyle.Neutral;
			}
			return EGiantSubtitleStyleExtensions.FromString(@string);
		}

		// Token: 0x0600C54E RID: 50510 RVA: 0x001CCCFC File Offset: 0x001CAEFC
		public override void Write(Utf8JsonWriter writer, EGiantSubtitleStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
