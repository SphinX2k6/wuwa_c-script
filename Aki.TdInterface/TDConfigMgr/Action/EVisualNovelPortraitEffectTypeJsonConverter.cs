using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002757 RID: 10071
	public class EVisualNovelPortraitEffectTypeJsonConverter : JsonConverter<EVisualNovelPortraitEffectType>
	{
		// Token: 0x0600D863 RID: 55395 RVA: 0x001F9FA0 File Offset: 0x001F81A0
		public override EVisualNovelPortraitEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelPortraitEffectType.Jump;
			}
			return EVisualNovelPortraitEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D864 RID: 55396 RVA: 0x001F9FC4 File Offset: 0x001F81C4
		public override void Write(Utf8JsonWriter writer, EVisualNovelPortraitEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
