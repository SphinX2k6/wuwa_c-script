using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001537 RID: 5431
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeInEffectConverter : JsonConverter<IFadeBackgroundFadeInEffect>
	{
		// Token: 0x06007B13 RID: 31507 RVA: 0x00128824 File Offset: 0x00126A24
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffect Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeInEffect.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeInEffect_SetValue>(ref reader, options));
		}

		// Token: 0x06007B14 RID: 31508 RVA: 0x00128832 File Offset: 0x00126A32
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffect value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffect_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
