using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200167D RID: 5757
	public class IDisableCameraOperationConverter : JsonConverter<IDisableCameraOperation>
	{
		// Token: 0x060081A5 RID: 33189 RVA: 0x001373B9 File Offset: 0x001355B9
		[return: Nullable(2)]
		public override IDisableCameraOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableCameraOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableCameraOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081A6 RID: 33190 RVA: 0x001373C7 File Offset: 0x001355C7
		public override void Write(Utf8JsonWriter writer, IDisableCameraOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableCameraOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
