using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200152C RID: 5420
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableUiOperationConverter : JsonConverter<IDisableUiOperation>
	{
		// Token: 0x06007AF2 RID: 31474 RVA: 0x0012868D File Offset: 0x0012688D
		[return: Nullable(2)]
		public override IDisableUiOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableUiOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableUiOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AF3 RID: 31475 RVA: 0x0012869B File Offset: 0x0012689B
		public override void Write(Utf8JsonWriter writer, IDisableUiOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableUiOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
