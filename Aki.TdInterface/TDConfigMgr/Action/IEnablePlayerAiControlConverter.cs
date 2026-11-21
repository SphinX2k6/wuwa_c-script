using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168B RID: 5771
	public class IEnablePlayerAiControlConverter : JsonConverter<IEnablePlayerAiControl>
	{
		// Token: 0x060081CF RID: 33231 RVA: 0x001375BF File Offset: 0x001357BF
		[return: Nullable(2)]
		public override IEnablePlayerAiControl Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnablePlayerAiControl.CreateFromSetValue(JsonSerializer.Deserialize<IEnablePlayerAiControl_SetValue>(ref reader, options));
		}

		// Token: 0x060081D0 RID: 33232 RVA: 0x001375CD File Offset: 0x001357CD
		public override void Write(Utf8JsonWriter writer, IEnablePlayerAiControl value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnablePlayerAiControl_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
