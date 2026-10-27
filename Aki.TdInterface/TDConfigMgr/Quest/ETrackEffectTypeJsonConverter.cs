using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A9 RID: 4777
	public class ETrackEffectTypeJsonConverter : JsonConverter<ETrackEffectType>
	{
		// Token: 0x06006BA1 RID: 27553 RVA: 0x00102F6C File Offset: 0x0010116C
		public override ETrackEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrackEffectType.AutoChange;
			}
			return ETrackEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x00102F90 File Offset: 0x00101190
		public override void Write(Utf8JsonWriter writer, ETrackEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
