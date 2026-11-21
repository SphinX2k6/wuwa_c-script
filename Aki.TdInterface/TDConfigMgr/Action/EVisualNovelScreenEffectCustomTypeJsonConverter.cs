using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002759 RID: 10073
	public class EVisualNovelScreenEffectCustomTypeJsonConverter : JsonConverter<EVisualNovelScreenEffectCustomType>
	{
		// Token: 0x0600D86C RID: 55404 RVA: 0x001FA0B4 File Offset: 0x001F82B4
		public override EVisualNovelScreenEffectCustomType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelScreenEffectCustomType.BurstEye;
			}
			return EVisualNovelScreenEffectCustomTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D86D RID: 55405 RVA: 0x001FA0D8 File Offset: 0x001F82D8
		public override void Write(Utf8JsonWriter writer, EVisualNovelScreenEffectCustomType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
