using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016AA RID: 5802
	public class PosAConverter : JsonConverter<PosA>
	{
		// Token: 0x0600822C RID: 33324 RVA: 0x00138467 File Offset: 0x00136667
		[return: Nullable(2)]
		public override PosA Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return PosA.CreateFromSetValue(JsonSerializer.Deserialize<PosA_SetValue>(ref reader, options));
		}

		// Token: 0x0600822D RID: 33325 RVA: 0x00138475 File Offset: 0x00136675
		public override void Write(Utf8JsonWriter writer, PosA value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<PosA_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
