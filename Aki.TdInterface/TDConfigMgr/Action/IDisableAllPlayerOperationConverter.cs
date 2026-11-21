using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200167B RID: 5755
	public class IDisableAllPlayerOperationConverter : JsonConverter<IDisableAllPlayerOperation>
	{
		// Token: 0x0600819F RID: 33183 RVA: 0x0013736F File Offset: 0x0013556F
		[return: Nullable(2)]
		public override IDisableAllPlayerOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableAllPlayerOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableAllPlayerOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081A0 RID: 33184 RVA: 0x0013737D File Offset: 0x0013557D
		public override void Write(Utf8JsonWriter writer, IDisableAllPlayerOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableAllPlayerOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
