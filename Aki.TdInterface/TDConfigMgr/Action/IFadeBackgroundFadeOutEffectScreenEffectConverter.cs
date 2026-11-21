using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001697 RID: 5783
	public class IFadeBackgroundFadeOutEffectScreenEffectConverter : JsonConverter<IFadeBackgroundFadeOutEffectScreenEffect>
	{
		// Token: 0x060081F3 RID: 33267 RVA: 0x00137866 File Offset: 0x00135A66
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffectScreenEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeOutEffectScreenEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeOutEffectScreenEffect_SetValue>(ref reader, options));
		}

		// Token: 0x060081F4 RID: 33268 RVA: 0x00137874 File Offset: 0x00135A74
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffectScreenEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffectScreenEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
