using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001688 RID: 5768
	public class IEnableAllPlayerOperationConverter : JsonConverter<IEnableAllPlayerOperation>
	{
		// Token: 0x060081C6 RID: 33222 RVA: 0x00137550 File Offset: 0x00135750
		[return: Nullable(2)]
		public override IEnableAllPlayerOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableAllPlayerOperation.CreateFromSetValue(JsonSerializer.Deserialize<IEnableAllPlayerOperation_SetValue>(ref reader, options));
		}

		// Token: 0x060081C7 RID: 33223 RVA: 0x0013755E File Offset: 0x0013575E
		public override void Write(Utf8JsonWriter writer, IEnableAllPlayerOperation value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableAllPlayerOperation_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
