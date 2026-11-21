using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026DD RID: 9949
	public class ESubtitleStyleJsonConverter : JsonConverter<ESubtitleStyle>
	{
		// Token: 0x0600D63E RID: 54846 RVA: 0x001F21D4 File Offset: 0x001F03D4
		public override ESubtitleStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubtitleStyle.LevelA;
			}
			return ESubtitleStyleExtensions.FromString(@string);
		}

		// Token: 0x0600D63F RID: 54847 RVA: 0x001F21F8 File Offset: 0x001F03F8
		public override void Write(Utf8JsonWriter writer, ESubtitleStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
