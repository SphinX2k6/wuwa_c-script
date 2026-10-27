using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001546 RID: 5446
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IResetPosByPosEntityConverter : JsonConverter<IResetPosByPosEntity>
	{
		// Token: 0x06007B40 RID: 31552 RVA: 0x00128F8B File Offset: 0x0012718B
		[return: Nullable(2)]
		public override IResetPosByPosEntity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IResetPosByPosEntity.CreateFromSetValue(JsonSerializer.Deserialize<IResetPosByPosEntity_SetValue>(ref reader, options));
		}

		// Token: 0x06007B41 RID: 31553 RVA: 0x00128F99 File Offset: 0x00127199
		public override void Write(Utf8JsonWriter writer, IResetPosByPosEntity value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IResetPosByPosEntity_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
