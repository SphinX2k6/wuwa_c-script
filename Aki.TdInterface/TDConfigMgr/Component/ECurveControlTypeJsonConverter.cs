using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200091B RID: 2331
	public class ECurveControlTypeJsonConverter : JsonConverter<ECurveControlType>
	{
		// Token: 0x060034AC RID: 13484 RVA: 0x00089D98 File Offset: 0x00087F98
		public override ECurveControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ECurveControlType.ChargeSlash;
			}
			return ECurveControlTypeExtensions.FromString(@string);
		}

		// Token: 0x060034AD RID: 13485 RVA: 0x00089DBC File Offset: 0x00087FBC
		public override void Write(Utf8JsonWriter writer, ECurveControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
