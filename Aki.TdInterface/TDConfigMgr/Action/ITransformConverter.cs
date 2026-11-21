using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A8 RID: 5800
	public class ITransformConverter : JsonConverter<ITransform>
	{
		// Token: 0x06008226 RID: 33318 RVA: 0x00138307 File Offset: 0x00136507
		[return: Nullable(2)]
		public override ITransform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return ITransform.CreateFromSetValue(JsonSerializer.Deserialize<ITransform_SetValue>(ref reader, options));
		}

		// Token: 0x06008227 RID: 33319 RVA: 0x00138315 File Offset: 0x00136515
		public override void Write(Utf8JsonWriter writer, ITransform value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<ITransform_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
