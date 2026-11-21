using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002583 RID: 9603
	public class EEffectTypeJsonConverter : JsonConverter<EEffectType>
	{
		// Token: 0x0600D029 RID: 53289 RVA: 0x001E291C File Offset: 0x001E0B1C
		public override EEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEffectType.Effect;
			}
			return EEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D02A RID: 53290 RVA: 0x001E2940 File Offset: 0x001E0B40
		public override void Write(Utf8JsonWriter writer, EEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
