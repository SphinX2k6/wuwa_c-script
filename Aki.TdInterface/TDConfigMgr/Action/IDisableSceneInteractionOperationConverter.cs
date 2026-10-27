using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001529 RID: 5417
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IDisableSceneInteractionOperationConverter : JsonConverter<IDisableSceneInteractionOperation>
	{
		// Token: 0x06007AE9 RID: 31465 RVA: 0x0012861E File Offset: 0x0012681E
		[return: Nullable(2)]
		public override IDisableSceneInteractionOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableSceneInteractionOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableSceneInteractionOperation_SetValue>(ref reader, options));
		}

		// Token: 0x06007AEA RID: 31466 RVA: 0x0012862C File Offset: 0x0012682C
		public override void Write(Utf8JsonWriter writer, IDisableSceneInteractionOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableSceneInteractionOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
