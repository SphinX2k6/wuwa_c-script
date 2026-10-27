using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200243C RID: 9276
	public class ESubtitleStyleJsonConverter : JsonConverter<ESubtitleStyle>
	{
		// Token: 0x0600C98E RID: 51598 RVA: 0x001D830C File Offset: 0x001D650C
		public override ESubtitleStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESubtitleStyle.LevelA;
			}
			return ESubtitleStyleExtensions.FromString(@string);
		}

		// Token: 0x0600C98F RID: 51599 RVA: 0x001D8330 File Offset: 0x001D6530
		public override void Write(Utf8JsonWriter writer, ESubtitleStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
