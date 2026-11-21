using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200169A RID: 5786
	public class IFadeBackgroundSpineConverter : JsonConverter<IFadeBackgroundSpine>
	{
		// Token: 0x060081FC RID: 33276 RVA: 0x001379C1 File Offset: 0x00135BC1
		[return: Nullable(2)]
		public override IFadeBackgroundSpine Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IFadeBackgroundSpine.CreateFromSetValue(JsonSerializer.Deserialize<IFadeBackgroundSpine_SetValue>(ref reader, options));
		}

		// Token: 0x060081FD RID: 33277 RVA: 0x001379CF File Offset: 0x00135BCF
		public override void Write(Utf8JsonWriter writer, IFadeBackgroundSpine value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IFadeBackgroundSpine_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
