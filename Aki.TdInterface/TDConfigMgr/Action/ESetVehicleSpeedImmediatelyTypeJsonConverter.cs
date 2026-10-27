using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002414 RID: 9236
	public class ESetVehicleSpeedImmediatelyTypeJsonConverter : JsonConverter<ESetVehicleSpeedImmediatelyType>
	{
		// Token: 0x0600C8DA RID: 51418 RVA: 0x001D6288 File Offset: 0x001D4488
		public override ESetVehicleSpeedImmediatelyType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESetVehicleSpeedImmediatelyType.TotalSpeed;
			}
			return ESetVehicleSpeedImmediatelyTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C8DB RID: 51419 RVA: 0x001D62AC File Offset: 0x001D44AC
		public override void Write(Utf8JsonWriter writer, ESetVehicleSpeedImmediatelyType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
