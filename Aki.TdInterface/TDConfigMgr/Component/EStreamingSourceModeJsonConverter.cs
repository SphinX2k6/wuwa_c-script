using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE8 RID: 2792
	public class EStreamingSourceModeJsonConverter : JsonConverter<EStreamingSourceMode>
	{
		// Token: 0x06003D28 RID: 15656 RVA: 0x0009CADC File Offset: 0x0009ACDC
		public override EStreamingSourceMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EStreamingSourceMode.Fixed;
			}
			return EStreamingSourceModeExtensions.FromString(@string);
		}

		// Token: 0x06003D29 RID: 15657 RVA: 0x0009CB00 File Offset: 0x0009AD00
		public override void Write(Utf8JsonWriter writer, EStreamingSourceMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
