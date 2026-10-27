using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001530 RID: 5424
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableMoveOperationConverter : JsonConverter<IEnableMoveOperation>
	{
		// Token: 0x06007AFE RID: 31486 RVA: 0x00128721 File Offset: 0x00126921
		[return: Nullable(2)]
		public override IEnableMoveOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableMoveOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableMoveOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AFF RID: 31487 RVA: 0x0012872F File Offset: 0x0012692F
		public override void Write(Utf8JsonWriter writer, IEnableMoveOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableMoveOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
