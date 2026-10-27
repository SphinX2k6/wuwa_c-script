using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x02007050 RID: 28752
	public class EMotorcycleRailMoveDataTypeJsonConverter : JsonConverter<EMotorcycleRailMoveDataType>
	{
		// Token: 0x06045FA8 RID: 286632 RVA: 0x01170F20 File Offset: 0x0116F120
		public override EMotorcycleRailMoveDataType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorcycleRailMoveDataType.AccelerateAlongRail;
			}
			return EMotorcycleRailMoveDataTypeExtensions.FromString(@string);
		}

		// Token: 0x06045FA9 RID: 286633 RVA: 0x01170F44 File Offset: 0x0116F144
		public override void Write(Utf8JsonWriter writer, EMotorcycleRailMoveDataType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
