using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000917 RID: 2327
	public class EConveyorBeltFieldTypeJsonConverter : JsonConverter<EConveyorBeltFieldType>
	{
		// Token: 0x0600349A RID: 13466 RVA: 0x00089BE0 File Offset: 0x00087DE0
		public override EConveyorBeltFieldType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConveyorBeltFieldType.DirectionalField;
			}
			return EConveyorBeltFieldTypeExtensions.FromString(@string);
		}

		// Token: 0x0600349B RID: 13467 RVA: 0x00089C04 File Offset: 0x00087E04
		public override void Write(Utf8JsonWriter writer, EConveyorBeltFieldType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
