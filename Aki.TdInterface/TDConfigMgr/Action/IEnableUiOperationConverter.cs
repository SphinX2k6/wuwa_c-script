using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001690 RID: 5776
	public class IEnableUiOperationConverter : JsonConverter<IEnableUiOperation>
	{
		// Token: 0x060081DE RID: 33246 RVA: 0x00137678 File Offset: 0x00135878
		[return: Nullable(2)]
		public override IEnableUiOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableUiOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableUiOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081DF RID: 33247 RVA: 0x00137686 File Offset: 0x00135886
		public override void Write(Utf8JsonWriter writer, IEnableUiOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableUiOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
