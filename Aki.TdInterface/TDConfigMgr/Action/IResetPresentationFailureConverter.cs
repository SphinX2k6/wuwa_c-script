using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001549 RID: 5449
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IResetPresentationFailureConverter : JsonConverter<IResetPresentationFailure>
	{
		// Token: 0x06007B49 RID: 31561 RVA: 0x001290E8 File Offset: 0x001272E8
		[return: Nullable(2)]
		public override IResetPresentationFailure Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IResetPresentationFailure.CreateFromSetValue(JsonSerializer.Deserialize<IResetPresentationFailure_SetValue>(ref reader, options));
		}

		// Token: 0x06007B4A RID: 31562 RVA: 0x001290F6 File Offset: 0x001272F6
		public override void Write(Utf8JsonWriter writer, IResetPresentationFailure value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IResetPresentationFailure_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
