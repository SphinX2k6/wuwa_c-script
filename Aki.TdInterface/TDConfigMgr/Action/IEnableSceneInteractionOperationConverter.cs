using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168C RID: 5772
	public class IEnableSceneInteractionOperationConverter : JsonConverter<IEnableSceneInteractionOperation>
	{
		// Token: 0x060081D2 RID: 33234 RVA: 0x001375E4 File Offset: 0x001357E4
		[return: Nullable(2)]
		public override IEnableSceneInteractionOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSceneInteractionOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSceneInteractionOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081D3 RID: 33235 RVA: 0x001375F2 File Offset: 0x001357F2
		public override void Write(Utf8JsonWriter writer, IEnableSceneInteractionOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSceneInteractionOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
