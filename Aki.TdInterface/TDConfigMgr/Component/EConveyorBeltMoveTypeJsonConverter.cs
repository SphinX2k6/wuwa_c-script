using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C6 RID: 2502
	public class EConveyorBeltMoveTypeJsonConverter : JsonConverter<EConveyorBeltMoveType>
	{
		// Token: 0x0600380F RID: 14351 RVA: 0x0009183C File Offset: 0x0008FA3C
		public override EConveyorBeltMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConveyorBeltMoveType.FixSpeed;
			}
			return EConveyorBeltMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x06003810 RID: 14352 RVA: 0x00091860 File Offset: 0x0008FA60
		public override void Write(Utf8JsonWriter writer, EConveyorBeltMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
