using System;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200152D RID: 5421
	[NullableContext(1)]
	[Nullable(new byte[]
	{
		0,
		1
	})]
	public class IEaseDataConverter : JsonConverter<IEaseData>
	{
		// Token: 0x06007AF5 RID: 31477 RVA: 0x001286B2 File Offset: 0x001268B2
		[return: Nullable(2)]
		public override IEaseData Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return IEaseData.CreateFromSetValue(JsonSerializer.Deserialize<IEaseData_SetValue>(ref reader, options));
		}

		// Token: 0x06007AF6 RID: 31478 RVA: 0x001286C0 File Offset: 0x001268C0
		public override void Write(Utf8JsonWriter writer, IEaseData value, JsonSerializerOptions options)
		{
			JsonSerializer.Serialize<IEaseData_SetValue>(writer, value.ToSetValue(), options);
		}
	}
}
