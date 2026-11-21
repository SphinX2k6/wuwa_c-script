using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002615 RID: 9749
	public class EMoraleAreaTypeJsonConverter : JsonConverter<EMoraleAreaType>
	{
		// Token: 0x0600D2BA RID: 53946 RVA: 0x001EA1CC File Offset: 0x001E83CC
		public override EMoraleAreaType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMoraleAreaType.MoraleArea1;
			}
			return EMoraleAreaTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D2BB RID: 53947 RVA: 0x001EA1F0 File Offset: 0x001E83F0
		public override void Write(Utf8JsonWriter writer, EMoraleAreaType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
