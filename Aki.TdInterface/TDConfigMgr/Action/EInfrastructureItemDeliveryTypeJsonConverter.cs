using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025D3 RID: 9683
	public class EInfrastructureItemDeliveryTypeJsonConverter : JsonConverter<EInfrastructureItemDeliveryType>
	{
		// Token: 0x0600D191 RID: 53649 RVA: 0x001E5AF8 File Offset: 0x001E3CF8
		public override EInfrastructureItemDeliveryType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInfrastructureItemDeliveryType.Observatory;
			}
			return EInfrastructureItemDeliveryTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D192 RID: 53650 RVA: 0x001E5B1C File Offset: 0x001E3D1C
		public override void Write(Utf8JsonWriter writer, EInfrastructureItemDeliveryType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
