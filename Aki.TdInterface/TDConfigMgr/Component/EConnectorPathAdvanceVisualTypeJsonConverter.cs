using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C0 RID: 2496
	public class EConnectorPathAdvanceVisualTypeJsonConverter : JsonConverter<EConnectorPathAdvanceVisualType>
	{
		// Token: 0x060037F4 RID: 14324 RVA: 0x00091538 File Offset: 0x0008F738
		public override EConnectorPathAdvanceVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConnectorPathAdvanceVisualType.VasePlant;
			}
			return EConnectorPathAdvanceVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x060037F5 RID: 14325 RVA: 0x0009155C File Offset: 0x0008F75C
		public override void Write(Utf8JsonWriter writer, EConnectorPathAdvanceVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
