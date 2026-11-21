using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200275B RID: 10075
	public class EVisualNovelScreenEffectTypeJsonConverter : JsonConverter<EVisualNovelScreenEffectType>
	{
		// Token: 0x0600D875 RID: 55413 RVA: 0x001FA20C File Offset: 0x001F840C
		public override EVisualNovelScreenEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelScreenEffectType.OneShot;
			}
			return EVisualNovelScreenEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D876 RID: 55414 RVA: 0x001FA230 File Offset: 0x001F8430
		public override void Write(Utf8JsonWriter writer, EVisualNovelScreenEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
