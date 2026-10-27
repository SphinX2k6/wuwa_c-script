using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001538 RID: 5432
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeInEffectScreenEffectConverter : JsonConverter<IFadeBackgroundFadeInEffectScreenEffect>
	{
		// Token: 0x06007B16 RID: 31510 RVA: 0x00128849 File Offset: 0x00126A49
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffectScreenEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeInEffectScreenEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeInEffectScreenEffect_SetValue>(ref reader, options));
		}

		// Token: 0x06007B17 RID: 31511 RVA: 0x00128857 File Offset: 0x00126A57
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffectScreenEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffectScreenEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
