using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001533 RID: 5427
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEnableSectionalUiConverter : JsonConverter<IEnableSectionalUi>
	{
		// Token: 0x06007B07 RID: 31495 RVA: 0x00128790 File Offset: 0x00126990
		[return: Nullable(2)]
		public override IEnableSectionalUi Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSectionalUi.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSectionalUi_SetValue>(ref reader, options));
		}

		// Token: 0x06007B08 RID: 31496 RVA: 0x0012879E File Offset: 0x0012699E
		public override void Write(Utf8JsonWriter writer, IEnableSectionalUi value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSectionalUi_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
