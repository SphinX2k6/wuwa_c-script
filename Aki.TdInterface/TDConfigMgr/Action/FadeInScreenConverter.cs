using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200151F RID: 5407
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FadeInScreenConverter : JsonConverter<FadeInScreen>
	{
		// Token: 0x06007ACB RID: 31435 RVA: 0x00128396 File Offset: 0x00126596
		[return: Nullable(2)]
		public override FadeInScreen Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return FadeInScreen.CreateFromSetValue(JsonSerializer.Deserialize<FadeInScreen_SetValue>(ref reader, options));
		}

		// Token: 0x06007ACC RID: 31436 RVA: 0x001283A4 File Offset: 0x001265A4
		public override void Write(Utf8JsonWriter writer, FadeInScreen value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<FadeInScreen_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
