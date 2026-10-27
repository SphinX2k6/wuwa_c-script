using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001524 RID: 5412
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableCameraOperationConverter : JsonConverter<IDisableCameraOperation>
	{
		// Token: 0x06007ADA RID: 31450 RVA: 0x00128565 File Offset: 0x00126765
		[return: Nullable(2)]
		public override IDisableCameraOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableCameraOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableCameraOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007ADB RID: 31451 RVA: 0x00128573 File Offset: 0x00126773
		public override void Write(Utf8JsonWriter writer, IDisableCameraOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableCameraOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
