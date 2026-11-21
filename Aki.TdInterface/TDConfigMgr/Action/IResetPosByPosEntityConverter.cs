using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020016A2 RID: 5794
	public class IResetPosByPosEntityConverter : JsonConverter<IResetPosByPosEntity>
	{
		// Token: 0x06008214 RID: 33300 RVA: 0x00137F37 File Offset: 0x00136137
		[return: Nullable(2)]
		public override IResetPosByPosEntity Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IResetPosByPosEntity.CreateFromSetValue(JsonSerializer.Deserialize<IResetPosByPosEntity_SetValue>(ref reader, options));
		}

		// Token: 0x06008215 RID: 33301 RVA: 0x00137F45 File Offset: 0x00136145
		public override void Write(Utf8JsonWriter writer, IResetPosByPosEntity value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IResetPosByPosEntity_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
