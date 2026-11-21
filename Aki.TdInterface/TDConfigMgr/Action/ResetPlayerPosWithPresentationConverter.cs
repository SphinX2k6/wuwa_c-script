using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016AB RID: 5803
	public class ResetPlayerPosWithPresentationConverter : JsonConverter<ResetPlayerPosWithPresentation>
	{
		// Token: 0x0600822F RID: 33327 RVA: 0x0013848C File Offset: 0x0013668C
		[return: Nullable(2)]
		public override ResetPlayerPosWithPresentation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return ResetPlayerPosWithPresentation.CreateFromSetValue(JsonSerializer.Deserialize<ResetPlayerPosWithPresentation_SetValue>(ref reader, options));
		}

		// Token: 0x06008230 RID: 33328 RVA: 0x0013849A File Offset: 0x0013669A
		public override void Write(Utf8JsonWriter writer, ResetPlayerPosWithPresentation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<ResetPlayerPosWithPresentation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
