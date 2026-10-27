using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200154E RID: 5454
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class PosAConverter : JsonConverter<PosA>
	{
		// Token: 0x06007B58 RID: 31576 RVA: 0x001294BB File Offset: 0x001276BB
		[return: Nullable(2)]
		public override PosA Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return PosA.CreateFromSetValue(JsonSerializer.Deserialize<PosA_SetValue>(ref reader, options));
		}

		// Token: 0x06007B59 RID: 31577 RVA: 0x001294C9 File Offset: 0x001276C9
		public override void Write(Utf8JsonWriter writer, PosA value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<PosA_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
