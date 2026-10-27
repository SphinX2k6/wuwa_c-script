using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200153C RID: 5436
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeOutEffectScreenEffectConverter : JsonConverter<IFadeBackgroundFadeOutEffectScreenEffect>
	{
		// Token: 0x06007B22 RID: 31522 RVA: 0x001289CA File Offset: 0x00126BCA
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffectScreenEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeOutEffectScreenEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeOutEffectScreenEffect_SetValue>(ref reader, options));
		}

		// Token: 0x06007B23 RID: 31523 RVA: 0x001289D8 File Offset: 0x00126BD8
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffectScreenEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffectScreenEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
