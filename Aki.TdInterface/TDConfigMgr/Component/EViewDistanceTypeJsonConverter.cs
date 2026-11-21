using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B0E RID: 2830
	public class EViewDistanceTypeJsonConverter : JsonConverter<EViewDistanceType>
	{
		// Token: 0x06003DD3 RID: 15827 RVA: 0x0009E10C File Offset: 0x0009C30C
		public override EViewDistanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EViewDistanceType.Low;
			}
			return EViewDistanceTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DD4 RID: 15828 RVA: 0x0009E130 File Offset: 0x0009C330
		public override void Write(Utf8JsonWriter writer, EViewDistanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
