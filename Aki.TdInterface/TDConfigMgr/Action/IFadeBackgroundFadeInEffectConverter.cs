using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001692 RID: 5778
	public class IFadeBackgroundFadeInEffectConverter : JsonConverter<IFadeBackgroundFadeInEffect>
	{
		// Token: 0x060081E4 RID: 33252 RVA: 0x001376C2 File Offset: 0x001358C2
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeInEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeInEffect_SetValue>(ref reader, options));
		}

		// Token: 0x060081E5 RID: 33253 RVA: 0x001376D0 File Offset: 0x001358D0
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
