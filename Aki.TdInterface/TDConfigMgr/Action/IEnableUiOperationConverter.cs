using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001535 RID: 5429
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableUiOperationConverter : JsonConverter<IEnableUiOperation>
	{
		// Token: 0x06007B0D RID: 31501 RVA: 0x001287DA File Offset: 0x001269DA
		[return: Nullable(2)]
		public override IEnableUiOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableUiOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableUiOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007B0E RID: 31502 RVA: 0x001287E8 File Offset: 0x001269E8
		public override void Write(Utf8JsonWriter writer, IEnableUiOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableUiOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
