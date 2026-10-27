using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200154F RID: 5455
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ResetPlayerPosWithPresentationConverter : JsonConverter<ResetPlayerPosWithPresentation>
	{
		// Token: 0x06007B5B RID: 31579 RVA: 0x001294E0 File Offset: 0x001276E0
		[return: Nullable(2)]
		public override ResetPlayerPosWithPresentation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return ResetPlayerPosWithPresentation.CreateFromSetValue(JsonSerializer.Deserialize<ResetPlayerPosWithPresentation_SetValue>(ref reader, options));
		}

		// Token: 0x06007B5C RID: 31580 RVA: 0x001294EE File Offset: 0x001276EE
		public override void Write(Utf8JsonWriter writer, ResetPlayerPosWithPresentation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<ResetPlayerPosWithPresentation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
