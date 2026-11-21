using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001693 RID: 5779
	public class IFadeBackgroundFadeInEffectScreenEffectConverter : JsonConverter<IFadeBackgroundFadeInEffectScreenEffect>
	{
		// Token: 0x060081E7 RID: 33255 RVA: 0x001376E7 File Offset: 0x001358E7
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffectScreenEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeInEffectScreenEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeInEffectScreenEffect_SetValue>(ref reader, options));
		}

		// Token: 0x060081E8 RID: 33256 RVA: 0x001376F5 File Offset: 0x001358F5
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffectScreenEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffectScreenEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
