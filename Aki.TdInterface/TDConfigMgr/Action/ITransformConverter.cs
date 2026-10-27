using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200154C RID: 5452
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class ITransformConverter : JsonConverter<ITransform>
	{
		// Token: 0x06007B52 RID: 31570 RVA: 0x0012935B File Offset: 0x0012755B
		[return: Nullable(2)]
		public override ITransform Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return ITransform.CreateFromSetValue(JsonSerializer.Deserialize<ITransform_SetValue>(ref reader, options));
		}

		// Token: 0x06007B53 RID: 31571 RVA: 0x00129369 File Offset: 0x00127569
		public override void Write(Utf8JsonWriter writer, ITransform value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<ITransform_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
