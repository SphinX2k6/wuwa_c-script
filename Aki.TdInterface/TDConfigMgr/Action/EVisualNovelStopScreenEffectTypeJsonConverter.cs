using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200275D RID: 10077
	public class EVisualNovelStopScreenEffectTypeJsonConverter : JsonConverter<EVisualNovelStopScreenEffectType>
	{
		// Token: 0x0600D87E RID: 55422 RVA: 0x001FA2E8 File Offset: 0x001F84E8
		public override EVisualNovelStopScreenEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelStopScreenEffectType.Persistent;
			}
			return EVisualNovelStopScreenEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D87F RID: 55423 RVA: 0x001FA30C File Offset: 0x001F850C
		public override void Write(Utf8JsonWriter writer, EVisualNovelStopScreenEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
