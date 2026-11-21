using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A5 RID: 5797
	public class IResetPresentationFailureConverter : JsonConverter<IResetPresentationFailure>
	{
		// Token: 0x0600821D RID: 33309 RVA: 0x00138094 File Offset: 0x00136294
		[return: Nullable(2)]
		public override IResetPresentationFailure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IResetPresentationFailure.CreateFromSetValue(JsonSerializer.Deserialize<IResetPresentationFailure_SetValue>(ref reader, options));
		}

		// Token: 0x0600821E RID: 33310 RVA: 0x001380A2 File Offset: 0x001362A2
		public override void Write(Utf8JsonWriter writer, IResetPresentationFailure value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IResetPresentationFailure_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
