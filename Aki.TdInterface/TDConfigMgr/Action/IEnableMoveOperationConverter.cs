using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168A RID: 5770
	public class IEnableMoveOperationConverter : JsonConverter<IEnableMoveOperation>
	{
		// Token: 0x060081CC RID: 33228 RVA: 0x0013759A File Offset: 0x0013579A
		[return: Nullable(2)]
		public override IEnableMoveOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableMoveOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableMoveOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081CD RID: 33229 RVA: 0x001375A8 File Offset: 0x001357A8
		public override void Write(Utf8JsonWriter writer, IEnableMoveOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableMoveOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
