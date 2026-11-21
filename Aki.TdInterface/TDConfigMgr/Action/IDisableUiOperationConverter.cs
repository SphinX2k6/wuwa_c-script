using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001686 RID: 5766
	public class IDisableUiOperationConverter : JsonConverter<IDisableUiOperation>
	{
		// Token: 0x060081C0 RID: 33216 RVA: 0x00137506 File Offset: 0x00135706
		[return: Nullable(2)]
		public override IDisableUiOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableUiOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableUiOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081C1 RID: 33217 RVA: 0x00137514 File Offset: 0x00135714
		public override void Write(Utf8JsonWriter writer, IDisableUiOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableUiOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
