using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001522 RID: 5410
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableAllPlayerOperationConverter : JsonConverter<IDisableAllPlayerOperation>
	{
		// Token: 0x06007AD4 RID: 31444 RVA: 0x0012851B File Offset: 0x0012671B
		[return: Nullable(2)]
		public override IDisableAllPlayerOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableAllPlayerOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableAllPlayerOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AD5 RID: 31445 RVA: 0x00128529 File Offset: 0x00126729
		public override void Write(Utf8JsonWriter writer, IDisableAllPlayerOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableAllPlayerOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
