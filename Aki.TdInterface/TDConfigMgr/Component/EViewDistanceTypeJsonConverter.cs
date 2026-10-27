using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A45 RID: 2629
	public class EViewDistanceTypeJsonConverter : JsonConverter<EViewDistanceType>
	{
		// Token: 0x060039E9 RID: 14825 RVA: 0x0009553C File Offset: 0x0009373C
		public override EViewDistanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EViewDistanceType.Low;
			}
			return EViewDistanceTypeExtensions.FromString(@string);
		}

		// Token: 0x060039EA RID: 14826 RVA: 0x00095560 File Offset: 0x00093760
		public override void Write(Utf8JsonWriter writer, EViewDistanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
