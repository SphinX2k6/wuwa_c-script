using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200096D RID: 2413
	public class EInhalationPerformanceTypeJsonConverter : JsonConverter<EInhalationPerformanceType>
	{
		// Token: 0x0600361D RID: 13853 RVA: 0x0008D3D0 File Offset: 0x0008B5D0
		public override EInhalationPerformanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInhalationPerformanceType.Role;
			}
			return EInhalationPerformanceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600361E RID: 13854 RVA: 0x0008D3F4 File Offset: 0x0008B5F4
		public override void Write(Utf8JsonWriter writer, EInhalationPerformanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
