using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000919 RID: 2329
	public class EConveyorBeltMoveTypeJsonConverter : JsonConverter<EConveyorBeltMoveType>
	{
		// Token: 0x060034A3 RID: 13475 RVA: 0x00089CBC File Offset: 0x00087EBC
		public override EConveyorBeltMoveType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EConveyorBeltMoveType.FixSpeed;
			}
			return EConveyorBeltMoveTypeExtensions.FromString(@string);
		}

		// Token: 0x060034A4 RID: 13476 RVA: 0x00089CE0 File Offset: 0x00087EE0
		public override void Write(Utf8JsonWriter writer, EConveyorBeltMoveType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
