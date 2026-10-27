using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200153B RID: 5435
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeOutEffectConverter : JsonConverter<IFadeBackgroundFadeOutEffect>
	{
		// Token: 0x06007B1F RID: 31519 RVA: 0x001289A5 File Offset: 0x00126BA5
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeOutEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeOutEffect_SetValue>(ref reader, options));
		}

		// Token: 0x06007B20 RID: 31520 RVA: 0x001289B3 File Offset: 0x00126BB3
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
