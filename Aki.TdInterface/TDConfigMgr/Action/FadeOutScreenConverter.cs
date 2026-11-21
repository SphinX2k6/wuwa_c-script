using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001679 RID: 5753
	public class FadeOutScreenConverter : JsonConverter<FadeOutScreen>
	{
		// Token: 0x06008199 RID: 33177 RVA: 0x0013720E File Offset: 0x0013540E
		[return: Nullable(2)]
		public override FadeOutScreen Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return FadeOutScreen.CreateFromSetValue(JsonSerializer.Deserialize<FadeOutScreen_SetValue>(ref reader, options));
		}

		// Token: 0x0600819A RID: 33178 RVA: 0x0013721C File Offset: 0x0013541C
		public override void Write(Utf8JsonWriter writer, FadeOutScreen value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<FadeOutScreen_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
