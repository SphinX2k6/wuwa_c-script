using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200152E RID: 5422
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableAllPlayerOperationConverter : JsonConverter<IEnableAllPlayerOperation>
	{
		// Token: 0x06007AF8 RID: 31480 RVA: 0x001286D7 File Offset: 0x001268D7
		[return: Nullable(2)]
		public override IEnableAllPlayerOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableAllPlayerOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableAllPlayerOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AF9 RID: 31481 RVA: 0x001286E5 File Offset: 0x001268E5
		public override void Write(Utf8JsonWriter writer, IEnableAllPlayerOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableAllPlayerOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
