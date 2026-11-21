using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200168E RID: 5774
	public class IEnableSectionalUiConverter : JsonConverter<IEnableSectionalUi>
	{
		// Token: 0x060081D8 RID: 33240 RVA: 0x0013762E File Offset: 0x0013582E
		[return: Nullable(2)]
		public override IEnableSectionalUi Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEnableSectionalUi.CreateFromSetValue(JsonSerializer.Deserialize<IEnableSectionalUi_SetValue>(ref reader, options));
		}

		// Token: 0x060081D9 RID: 33241 RVA: 0x0013763C File Offset: 0x0013583C
		public override void Write(Utf8JsonWriter writer, IEnableSectionalUi value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEnableSectionalUi_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
