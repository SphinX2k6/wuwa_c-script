using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002444 RID: 9284
	public class ESwitchEffectStateEffectTypeJsonConverter : JsonConverter<ESwitchEffectStateEffectType>
	{
		// Token: 0x0600C9B2 RID: 51634 RVA: 0x001D86EC File Offset: 0x001D68EC
		public override ESwitchEffectStateEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESwitchEffectStateEffectType.ScreenEffect;
			}
			return ESwitchEffectStateEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C9B3 RID: 51635 RVA: 0x001D8710 File Offset: 0x001D6910
		public override void Write(Utf8JsonWriter writer, ESwitchEffectStateEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
