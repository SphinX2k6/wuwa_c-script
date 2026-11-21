using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001691 RID: 5777
	public class IFadeBackgroundFadeInEffectBlackConverter : JsonConverter<IFadeBackgroundFadeInEffectBlack>
	{
		// Token: 0x060081E1 RID: 33249 RVA: 0x0013769D File Offset: 0x0013589D
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffectBlack Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeInEffectBlack.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeInEffectBlack_SetValue>(ref reader, options));
		}

		// Token: 0x060081E2 RID: 33250 RVA: 0x001376AB File Offset: 0x001358AB
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffectBlack value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffectBlack_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
