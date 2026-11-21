using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02001687 RID: 5767
	public class IEaseDataConverter : JsonConverter<IEaseData>
	{
		// Token: 0x060081C3 RID: 33219 RVA: 0x0013752B File Offset: 0x0013572B
		[return: Nullable(2)]
		public override IEaseData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEaseData.CreateFromSetValue(JsonSerializer.Deserialize<IEaseData_SetValue>(ref reader, options));
		}

		// Token: 0x060081C4 RID: 33220 RVA: 0x00137539 File Offset: 0x00135739
		public override void Write(Utf8JsonWriter writer, IEaseData value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEaseData_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
