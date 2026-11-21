using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200259D RID: 9629
	public class EExitVehicleTypeJsonConverter : JsonConverter<EExitVehicleType>
	{
		// Token: 0x0600D09E RID: 53406 RVA: 0x001E3BB0 File Offset: 0x001E1DB0
		public override EExitVehicleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExitVehicleType.Launch;
			}
			return EExitVehicleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D09F RID: 53407 RVA: 0x001E3BD4 File Offset: 0x001E1DD4
		public override void Write(Utf8JsonWriter writer, EExitVehicleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
