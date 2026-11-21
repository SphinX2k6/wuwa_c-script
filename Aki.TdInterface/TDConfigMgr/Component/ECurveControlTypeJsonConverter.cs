using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C8 RID: 2504
	public class ECurveControlTypeJsonConverter : JsonConverter<ECurveControlType>
	{
		// Token: 0x06003818 RID: 14360 RVA: 0x00091918 File Offset: 0x0008FB18
		public override ECurveControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECurveControlType.ChargeSlash;
			}
			return ECurveControlTypeExtensions.FromString(@string);
		}

		// Token: 0x06003819 RID: 14361 RVA: 0x0009193C File Offset: 0x0008FB3C
		public override void Write(Utf8JsonWriter writer, ECurveControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
