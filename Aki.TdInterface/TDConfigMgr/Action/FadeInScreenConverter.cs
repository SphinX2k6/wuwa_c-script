using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001678 RID: 5752
	public class FadeInScreenConverter : JsonConverter<FadeInScreen>
	{
		// Token: 0x06008196 RID: 33174 RVA: 0x001371E9 File Offset: 0x001353E9
		[return: Nullable(2)]
		public override FadeInScreen Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return FadeInScreen.CreateFromSetValue(JsonSerializer.Deserialize<FadeInScreen_SetValue>(ref reader, options));
		}

		// Token: 0x06008197 RID: 33175 RVA: 0x001371F7 File Offset: 0x001353F7
		public override void Write(Utf8JsonWriter writer, FadeInScreen value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<FadeInScreen_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
