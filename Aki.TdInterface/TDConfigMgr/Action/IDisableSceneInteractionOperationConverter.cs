using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001683 RID: 5763
	public class IDisableSceneInteractionOperationConverter : JsonConverter<IDisableSceneInteractionOperation>
	{
		// Token: 0x060081B7 RID: 33207 RVA: 0x00137497 File Offset: 0x00135697
		[return: Nullable(2)]
		public override IDisableSceneInteractionOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IDisableSceneInteractionOperation.CreateFromSetValue(JsonSerializer.Deserialize<IDisableSceneInteractionOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081B8 RID: 33208 RVA: 0x001374A5 File Offset: 0x001356A5
		public override void Write(Utf8JsonWriter writer, IDisableSceneInteractionOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IDisableSceneInteractionOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
