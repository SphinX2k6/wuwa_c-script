using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2E RID: 2606
	public class EInteractStyleTypeJsonConverter : JsonConverter<EInteractStyleType>
	{
		// Token: 0x060039E3 RID: 14819 RVA: 0x00095AFC File Offset: 0x00093CFC
		public override EInteractStyleType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractStyleType.Panorama;
			}
			return EInteractStyleTypeExtensions.FromString(@string);
		}

		// Token: 0x060039E4 RID: 14820 RVA: 0x00095B20 File Offset: 0x00093D20
		public override void Write(Utf8JsonWriter writer, EInteractStyleType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
