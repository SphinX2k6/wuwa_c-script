using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A7 RID: 4775
	public class ETrackEffectJsonConverter : JsonConverter<ETrackEffect>
	{
		// Token: 0x06006B98 RID: 27544 RVA: 0x00102E90 File Offset: 0x00101090
		public override ETrackEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackEffect.LongLightBeam;
			}
			return ETrackEffectExtensions.FromString(@string);
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x00102EB4 File Offset: 0x001010B4
		public override void Write(Utf8JsonWriter writer, ETrackEffect value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
