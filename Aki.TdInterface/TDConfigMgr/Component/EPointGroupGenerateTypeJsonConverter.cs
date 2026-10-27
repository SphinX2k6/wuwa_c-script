using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D9 RID: 2521
	public class EPointGroupGenerateTypeJsonConverter : JsonConverter<EPointGroupGenerateType>
	{
		// Token: 0x06003803 RID: 14339 RVA: 0x00091580 File Offset: 0x0008F780
		public override EPointGroupGenerateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPointGroupGenerateType.Layer;
			}
			return EPointGroupGenerateTypeExtensions.FromString(@string);
		}

		// Token: 0x06003804 RID: 14340 RVA: 0x000915A4 File Offset: 0x0008F7A4
		public override void Write(Utf8JsonWriter writer, EPointGroupGenerateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
