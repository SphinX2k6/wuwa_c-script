using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001695 RID: 5781
	public class IFadeBackgroundFadeOutEffectBlackConverter : JsonConverter<IFadeBackgroundFadeOutEffectBlack>
	{
		// Token: 0x060081ED RID: 33261 RVA: 0x0013781C File Offset: 0x00135A1C
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffectBlack Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeOutEffectBlack.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeOutEffectBlack_SetValue>(ref reader, options));
		}

		// Token: 0x060081EE RID: 33262 RVA: 0x0013782A File Offset: 0x00135A2A
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffectBlack value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffectBlack_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
