using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001527 RID: 5415
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableModulePlayerOperationConverter : JsonConverter<IDisableModulePlayerOperation>
	{
		// Token: 0x06007AE3 RID: 31459 RVA: 0x001285D4 File Offset: 0x001267D4
		[return: Nullable(2)]
		public override IDisableModulePlayerOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableModulePlayerOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableModulePlayerOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AE4 RID: 31460 RVA: 0x001285E2 File Offset: 0x001267E2
		public override void Write(Utf8JsonWriter writer, IDisableModulePlayerOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableModulePlayerOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
