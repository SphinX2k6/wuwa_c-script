using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001547 RID: 5447
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IResetPosByResetPointConverter : JsonConverter<IResetPosByResetPoint>
	{
		// Token: 0x06007B43 RID: 31555 RVA: 0x00128FB0 File Offset: 0x001271B0
		[return: Nullable(2)]
		public override IResetPosByResetPoint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IResetPosByResetPoint.CreateFromSetValue(JsonSerializer.Deserialize<IResetPosByResetPoint_SetValue>(ref reader, options));
		}

		// Token: 0x06007B44 RID: 31556 RVA: 0x00128FBE File Offset: 0x001271BE
		public override void Write(Utf8JsonWriter writer, IResetPosByResetPoint value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IResetPosByResetPoint_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
