using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AE RID: 2478
	public class EBuffProducerModeJsonConverter : JsonConverter<EBuffProducerMode>
	{
		// Token: 0x060037A3 RID: 14243 RVA: 0x0008D0D8 File Offset: 0x0008B2D8
		public override EBuffProducerMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBuffProducerMode.Immediate;
			}
			return EBuffProducerModeExtensions.FromString(@string);
		}

		// Token: 0x060037A4 RID: 14244 RVA: 0x0008D0FC File Offset: 0x0008B2FC
		public override void Write(Utf8JsonWriter writer, EBuffProducerMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
