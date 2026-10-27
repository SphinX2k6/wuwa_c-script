using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001528 RID: 5416
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableMoveOperationConverter : JsonConverter<IDisableMoveOperation>
	{
		// Token: 0x06007AE6 RID: 31462 RVA: 0x001285F9 File Offset: 0x001267F9
		[return: Nullable(2)]
		public override IDisableMoveOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableMoveOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableMoveOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AE7 RID: 31463 RVA: 0x00128607 File Offset: 0x00126807
		public override void Write(Utf8JsonWriter writer, IDisableMoveOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableMoveOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
