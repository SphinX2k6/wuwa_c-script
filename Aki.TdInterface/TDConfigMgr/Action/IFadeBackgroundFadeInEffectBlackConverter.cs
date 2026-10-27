using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001536 RID: 5430
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundFadeInEffectBlackConverter : JsonConverter<IFadeBackgroundFadeInEffectBlack>
	{
		// Token: 0x06007B10 RID: 31504 RVA: 0x001287FF File Offset: 0x001269FF
		[return: Nullable(2)]
		public override IFadeBackgroundFadeInEffectBlack Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundFadeInEffectBlack.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundFadeInEffectBlack_SetValue>(ref reader, options));
		}

		// Token: 0x06007B11 RID: 31505 RVA: 0x0012880D File Offset: 0x00126A0D
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundFadeInEffectBlack value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundFadeInEffectBlack_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
