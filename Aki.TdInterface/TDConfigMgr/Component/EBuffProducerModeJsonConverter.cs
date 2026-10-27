using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000905 RID: 2309
	public class EBuffProducerModeJsonConverter : JsonConverter<EBuffProducerMode>
	{
		// Token: 0x06003449 RID: 13385 RVA: 0x00085868 File Offset: 0x00083A68
		public override EBuffProducerMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBuffProducerMode.Immediate;
			}
			return EBuffProducerModeExtensions.FromString(@string);
		}

		// Token: 0x0600344A RID: 13386 RVA: 0x0008588C File Offset: 0x00083A8C
		public override void Write(Utf8JsonWriter writer, EBuffProducerMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
