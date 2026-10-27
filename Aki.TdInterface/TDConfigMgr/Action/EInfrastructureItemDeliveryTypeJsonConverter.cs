using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200235E RID: 9054
	public class EInfrastructureItemDeliveryTypeJsonConverter : JsonConverter<EInfrastructureItemDeliveryType>
	{
		// Token: 0x0600C5A7 RID: 50599 RVA: 0x001CD818 File Offset: 0x001CBA18
		public override EInfrastructureItemDeliveryType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInfrastructureItemDeliveryType.Observatory;
			}
			return EInfrastructureItemDeliveryTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C5A8 RID: 50600 RVA: 0x001CD83C File Offset: 0x001CBA3C
		public override void Write(Utf8JsonWriter writer, EInfrastructureItemDeliveryType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
