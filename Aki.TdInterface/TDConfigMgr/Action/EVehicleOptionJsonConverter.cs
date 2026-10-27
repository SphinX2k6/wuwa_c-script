using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200249E RID: 9374
	public class EVehicleOptionJsonConverter : JsonConverter<EVehicleOption>
	{
		// Token: 0x0600CB47 RID: 52039 RVA: 0x001DECF4 File Offset: 0x001DCEF4
		public override EVehicleOption Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVehicleOption.EnterVehicle;
			}
			return EVehicleOptionExtensions.FromString(@string);
		}

		// Token: 0x0600CB48 RID: 52040 RVA: 0x001DED18 File Offset: 0x001DCF18
		public override void Write(Utf8JsonWriter writer, EVehicleOption value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
