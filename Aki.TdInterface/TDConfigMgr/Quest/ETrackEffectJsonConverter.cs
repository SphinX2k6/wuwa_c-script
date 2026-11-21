using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013ED RID: 5101
	public class ETrackEffectJsonConverter : JsonConverter<ETrackEffect>
	{
		// Token: 0x06007206 RID: 29190 RVA: 0x00110E58 File Offset: 0x0010F058
		public override ETrackEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackEffect.LongLightBeam;
			}
			return ETrackEffectExtensions.FromString(@string);
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x00110E7C File Offset: 0x0010F07C
		public override void Write(Utf8JsonWriter writer, ETrackEffect value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
