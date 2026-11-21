using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001680 RID: 5760
	public class IDisableModulePlayerOperationConverter : JsonConverter<IDisableModulePlayerOperation>
	{
		// Token: 0x060081AE RID: 33198 RVA: 0x00137428 File Offset: 0x00135628
		[return: Nullable(2)]
		public override IDisableModulePlayerOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableModulePlayerOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableModulePlayerOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081AF RID: 33199 RVA: 0x00137436 File Offset: 0x00135636
		public override void Write(Utf8JsonWriter writer, IDisableModulePlayerOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableModulePlayerOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
