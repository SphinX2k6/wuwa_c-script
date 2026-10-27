using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B4 RID: 9396
	public class EVisualNovelPortraitEffectTypeJsonConverter : JsonConverter<EVisualNovelPortraitEffectType>
	{
		// Token: 0x0600CBAA RID: 52138 RVA: 0x001DFDE8 File Offset: 0x001DDFE8
		public override EVisualNovelPortraitEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelPortraitEffectType.Jump;
			}
			return EVisualNovelPortraitEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBAB RID: 52139 RVA: 0x001DFE0C File Offset: 0x001DE00C
		public override void Write(Utf8JsonWriter writer, EVisualNovelPortraitEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
