using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002703 RID: 9987
	public class ETargetVehicleJsonConverter : JsonConverter<ETargetVehicle>
	{
		// Token: 0x0600D6E9 RID: 55017 RVA: 0x001F631C File Offset: 0x001F451C
		public override ETargetVehicle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetVehicle.Current;
			}
			return ETargetVehicleExtensions.FromString(@string);
		}

		// Token: 0x0600D6EA RID: 55018 RVA: 0x001F6340 File Offset: 0x001F4540
		public override void Write(Utf8JsonWriter writer, ETargetVehicle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
