using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A3 RID: 5795
	public class IResetPosByResetPointConverter : JsonConverter<IResetPosByResetPoint>
	{
		// Token: 0x06008217 RID: 33303 RVA: 0x00137F5C File Offset: 0x0013615C
		[return: Nullable(2)]
		public override IResetPosByResetPoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IResetPosByResetPoint.CreateFromSetValue(JsonSerializer.Deserialize<IResetPosByResetPoint_SetValue>(ref reader, options));
		}

		// Token: 0x06008218 RID: 33304 RVA: 0x00137F6A File Offset: 0x0013616A
		public override void Write(Utf8JsonWriter writer, IResetPosByResetPoint value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IResetPosByResetPoint_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
