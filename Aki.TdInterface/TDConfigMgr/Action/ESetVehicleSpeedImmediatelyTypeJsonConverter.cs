using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026B3 RID: 9907
	public class ESetVehicleSpeedImmediatelyTypeJsonConverter : JsonConverter<ESetVehicleSpeedImmediatelyType>
	{
		// Token: 0x0600D581 RID: 54657 RVA: 0x001EFE84 File Offset: 0x001EE084
		public override ESetVehicleSpeedImmediatelyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetVehicleSpeedImmediatelyType.TotalSpeed;
			}
			return ESetVehicleSpeedImmediatelyTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D582 RID: 54658 RVA: 0x001EFEA8 File Offset: 0x001EE0A8
		public override void Write(Utf8JsonWriter writer, ESetVehicleSpeedImmediatelyType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
