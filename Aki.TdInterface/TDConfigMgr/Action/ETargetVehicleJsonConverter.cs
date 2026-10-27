using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002462 RID: 9314
	public class ETargetVehicleJsonConverter : JsonConverter<ETargetVehicle>
	{
		// Token: 0x0600CA39 RID: 51769 RVA: 0x001DC268 File Offset: 0x001DA468
		public override ETargetVehicle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetVehicle.Current;
			}
			return ETargetVehicleExtensions.FromString(@string);
		}

		// Token: 0x0600CA3A RID: 51770 RVA: 0x001DC28C File Offset: 0x001DA48C
		public override void Write(Utf8JsonWriter writer, ETargetVehicle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
