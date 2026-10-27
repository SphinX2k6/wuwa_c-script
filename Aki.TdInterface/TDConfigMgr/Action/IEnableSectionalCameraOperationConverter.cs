using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001532 RID: 5426
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableSectionalCameraOperationConverter : JsonConverter<IEnableSectionalCameraOperation>
	{
		// Token: 0x06007B04 RID: 31492 RVA: 0x0012876B File Offset: 0x0012696B
		[return: Nullable(2)]
		public override IEnableSectionalCameraOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSectionalCameraOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSectionalCameraOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007B05 RID: 31493 RVA: 0x00128779 File Offset: 0x00126979
		public override void Write(Utf8JsonWriter writer, IEnableSectionalCameraOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSectionalCameraOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
