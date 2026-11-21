using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001682 RID: 5762
	public class IDisablePlayerAiControlConverter : JsonConverter<IDisablePlayerAiControl>
	{
		// Token: 0x060081B4 RID: 33204 RVA: 0x00137472 File Offset: 0x00135672
		[return: Nullable(2)]
		public override IDisablePlayerAiControl Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisablePlayerAiControl.CreateFromSetValue(JsonSerializer.Deserialize<IDisablePlayerAiControl_SetValue>(ref reader, options));
		}

		// Token: 0x060081B5 RID: 33205 RVA: 0x00137480 File Offset: 0x00135680
		public override void Write(Utf8JsonWriter writer, IDisablePlayerAiControl value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisablePlayerAiControl_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
