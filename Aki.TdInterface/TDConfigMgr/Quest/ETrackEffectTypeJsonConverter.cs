using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013EF RID: 5103
	public class ETrackEffectTypeJsonConverter : JsonConverter<ETrackEffectType>
	{
		// Token: 0x0600720F RID: 29199 RVA: 0x00110F34 File Offset: 0x0010F134
		public override ETrackEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackEffectType.AutoChange;
			}
			return ETrackEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x00110F58 File Offset: 0x0010F158
		public override void Write(Utf8JsonWriter writer, ETrackEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
