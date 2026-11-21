using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001696 RID: 5782
	public class IFadeBackgroundFadeOutEffectConverter : JsonConverter<IFadeBackgroundFadeOutEffect>
	{
		// Token: 0x060081F0 RID: 33264 RVA: 0x00137841 File Offset: 0x00135A41
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeOutEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeOutEffect_SetValue>(ref reader, options));
		}

		// Token: 0x060081F1 RID: 33265 RVA: 0x0013784F File Offset: 0x00135A4F
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
