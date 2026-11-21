using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168D RID: 5773
	public class IEnableSectionalCameraOperationConverter : JsonConverter<IEnableSectionalCameraOperation>
	{
		// Token: 0x060081D5 RID: 33237 RVA: 0x00137609 File Offset: 0x00135809
		[return: Nullable(2)]
		public override IEnableSectionalCameraOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSectionalCameraOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSectionalCameraOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081D6 RID: 33238 RVA: 0x00137617 File Offset: 0x00135817
		public override void Write(Utf8JsonWriter writer, IEnableSectionalCameraOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSectionalCameraOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
