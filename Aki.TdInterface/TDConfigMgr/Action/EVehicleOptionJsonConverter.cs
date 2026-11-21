using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002741 RID: 10049
	public class EVehicleOptionJsonConverter : JsonConverter<EVehicleOption>
	{
		// Token: 0x0600D800 RID: 55296 RVA: 0x001F8EBC File Offset: 0x001F70BC
		public override EVehicleOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVehicleOption.EnterVehicle;
			}
			return EVehicleOptionExtensions.FromString(@string);
		}

		// Token: 0x0600D801 RID: 55297 RVA: 0x001F8EE0 File Offset: 0x001F70E0
		public override void Write(Utf8JsonWriter writer, EVehicleOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
