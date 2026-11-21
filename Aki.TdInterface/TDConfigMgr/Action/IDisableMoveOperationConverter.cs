using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001681 RID: 5761
	public class IDisableMoveOperationConverter : JsonConverter<IDisableMoveOperation>
	{
		// Token: 0x060081B1 RID: 33201 RVA: 0x0013744D File Offset: 0x0013564D
		[return: Nullable(2)]
		public override IDisableMoveOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableMoveOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableMoveOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081B2 RID: 33202 RVA: 0x0013745B File Offset: 0x0013565B
		public override void Write(Utf8JsonWriter writer, IDisableMoveOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableMoveOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
