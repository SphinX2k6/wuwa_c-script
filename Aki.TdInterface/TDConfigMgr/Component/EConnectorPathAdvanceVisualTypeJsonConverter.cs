using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000913 RID: 2323
	public class EConnectorPathAdvanceVisualTypeJsonConverter : JsonConverter<EConnectorPathAdvanceVisualType>
	{
		// Token: 0x06003488 RID: 13448 RVA: 0x000899B8 File Offset: 0x00087BB8
		public override EConnectorPathAdvanceVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConnectorPathAdvanceVisualType.VasePlant;
			}
			return EConnectorPathAdvanceVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x06003489 RID: 13449 RVA: 0x000899DC File Offset: 0x00087BDC
		public override void Write(Utf8JsonWriter writer, EConnectorPathAdvanceVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
