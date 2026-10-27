using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001531 RID: 5425
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableSceneInteractionOperationConverter : JsonConverter<IEnableSceneInteractionOperation>
	{
		// Token: 0x06007B01 RID: 31489 RVA: 0x00128746 File Offset: 0x00126946
		[return: Nullable(2)]
		public override IEnableSceneInteractionOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSceneInteractionOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSceneInteractionOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007B02 RID: 31490 RVA: 0x00128754 File Offset: 0x00126954
		public override void Write(Utf8JsonWriter writer, IEnableSceneInteractionOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSceneInteractionOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
