using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200153F RID: 5439
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IFadeBackgroundSpineConverter : JsonConverter<IFadeBackgroundSpine>
	{
		// Token: 0x06007B2B RID: 31531 RVA: 0x00128B25 File Offset: 0x00126D25
		[return: Nullable(2)]
		public override IFadeBackgroundSpine Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundSpine.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundSpine_SetValue>(ref reader, options));
		}

		// Token: 0x06007B2C RID: 31532 RVA: 0x00128B33 File Offset: 0x00126D33
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundSpine value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundSpine_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
