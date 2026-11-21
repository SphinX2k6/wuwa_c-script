using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026E5 RID: 9957
	public class ESwitchEffectStateEffectTypeJsonConverter : JsonConverter<ESwitchEffectStateEffectType>
	{
		// Token: 0x0600D662 RID: 54882 RVA: 0x001F25B4 File Offset: 0x001F07B4
		public override ESwitchEffectStateEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwitchEffectStateEffectType.ScreenEffect;
			}
			return ESwitchEffectStateEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D663 RID: 54883 RVA: 0x001F25D8 File Offset: 0x001F07D8
		public override void Write(Utf8JsonWriter writer, ESwitchEffectStateEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
