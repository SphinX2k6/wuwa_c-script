using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200152F RID: 5423
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableCameraOperationConverter : JsonConverter<IEnableCameraOperation>
	{
		// Token: 0x06007AFB RID: 31483 RVA: 0x001286FC File Offset: 0x001268FC
		[return: Nullable(2)]
		public override IEnableCameraOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableCameraOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableCameraOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AFC RID: 31484 RVA: 0x0012870A File Offset: 0x0012690A
		public override void Write(Utf8JsonWriter writer, IEnableCameraOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableCameraOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
