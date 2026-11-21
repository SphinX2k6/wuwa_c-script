using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C4 RID: 2500
	public class EConveyorBeltFieldTypeJsonConverter : JsonConverter<EConveyorBeltFieldType>
	{
		// Token: 0x06003806 RID: 14342 RVA: 0x00091760 File Offset: 0x0008F960
		public override EConveyorBeltFieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConveyorBeltFieldType.DirectionalField;
			}
			return EConveyorBeltFieldTypeExtensions.FromString(@string);
		}

		// Token: 0x06003807 RID: 14343 RVA: 0x00091784 File Offset: 0x0008F984
		public override void Write(Utf8JsonWriter writer, EConveyorBeltFieldType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
