using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.NewWorld.Vehicle.Motorcycle.MotorcycleRailMove
{
	// Token: 0x020061D1 RID: 25041
	public class EMotorcycleRailMoveDataTypeJsonConverter : JsonConverter<EMotorcycleRailMoveDataType>
	{
		// Token: 0x0603C18E RID: 246158 RVA: 0x0111ACBC File Offset: 0x01118EBC
		public override EMotorcycleRailMoveDataType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMotorcycleRailMoveDataType.AccelerateAlongRail;
			}
			return EMotorcycleRailMoveDataTypeExtensions.FromString(@string);
		}

		// Token: 0x0603C18F RID: 246159 RVA: 0x0111ACE0 File Offset: 0x01118EE0
		public override void Write(Utf8JsonWriter writer, EMotorcycleRailMoveDataType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
