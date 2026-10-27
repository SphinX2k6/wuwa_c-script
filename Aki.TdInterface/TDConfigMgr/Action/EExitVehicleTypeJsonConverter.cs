using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200232C RID: 9004
	public class EExitVehicleTypeJsonConverter : JsonConverter<EExitVehicleType>
	{
		// Token: 0x0600C4C6 RID: 50374 RVA: 0x001CBAF8 File Offset: 0x001C9CF8
		public override EExitVehicleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExitVehicleType.Launch;
			}
			return EExitVehicleTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4C7 RID: 50375 RVA: 0x001CBB1C File Offset: 0x001C9D1C
		public override void Write(Utf8JsonWriter writer, EExitVehicleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
