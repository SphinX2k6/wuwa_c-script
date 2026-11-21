using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001689 RID: 5769
	public class IEnableCameraOperationConverter : JsonConverter<IEnableCameraOperation>
	{
		// Token: 0x060081C9 RID: 33225 RVA: 0x00137575 File Offset: 0x00135775
		[return: Nullable(2)]
		public override IEnableCameraOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableCameraOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableCameraOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081CA RID: 33226 RVA: 0x00137583 File Offset: 0x00135783
		public override void Write(Utf8JsonWriter writer, IEnableCameraOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableCameraOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
