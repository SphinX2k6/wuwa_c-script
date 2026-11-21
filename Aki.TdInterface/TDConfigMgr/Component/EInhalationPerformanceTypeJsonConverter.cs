using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A20 RID: 2592
	public class EInhalationPerformanceTypeJsonConverter : JsonConverter<EInhalationPerformanceType>
	{
		// Token: 0x060039A4 RID: 14756 RVA: 0x0009533C File Offset: 0x0009353C
		public override EInhalationPerformanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInhalationPerformanceType.Role;
			}
			return EInhalationPerformanceTypeExtensions.FromString(@string);
		}

		// Token: 0x060039A5 RID: 14757 RVA: 0x00095360 File Offset: 0x00093560
		public override void Write(Utf8JsonWriter writer, EInhalationPerformanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
