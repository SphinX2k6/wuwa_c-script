using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001520 RID: 5408
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class FadeOutScreenConverter : JsonConverter<FadeOutScreen>
	{
		// Token: 0x06007ACE RID: 31438 RVA: 0x001283BB File Offset: 0x001265BB
		[return: Nullable(2)]
		public override FadeOutScreen Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return FadeOutScreen.CreateFromSetValue(JsonSerializer.Deserialize<FadeOutScreen_SetValue>(ref reader, options));
		}

		// Token: 0x06007ACF RID: 31439 RVA: 0x001283C9 File Offset: 0x001265C9
		public override void Write(Utf8JsonWriter writer, FadeOutScreen value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<FadeOutScreen_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
