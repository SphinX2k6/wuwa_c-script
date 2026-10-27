using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200153A RID: 5434
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeOutEffectBlackConverter : JsonConverter<IFadeBackgroundFadeOutEffectBlack>
	{
		// Token: 0x06007B1C RID: 31516 RVA: 0x00128980 File Offset: 0x00126B80
		[return: Nullable(2)]
		public override IFadeBackgroundFadeOutEffectBlack Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeOutEffectBlack.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeOutEffectBlack_SetValue>(ref reader, options));
		}

		// Token: 0x06007B1D RID: 31517 RVA: 0x0012898E File Offset: 0x00126B8E
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeOutEffectBlack value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeOutEffectBlack_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
