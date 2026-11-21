using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002589 RID: 9609
	public class EEnableClientFunctionTypeJsonConverter : JsonConverter<EEnableClientFunctionType>
	{
		// Token: 0x0600D044 RID: 53316 RVA: 0x001E2C20 File Offset: 0x001E0E20
		public override EEnableClientFunctionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableClientFunctionType.HealthBarDisplay;
			}
			return EEnableClientFunctionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D045 RID: 53317 RVA: 0x001E2C44 File Offset: 0x001E0E44
		public override void Write(Utf8JsonWriter writer, EEnableClientFunctionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
