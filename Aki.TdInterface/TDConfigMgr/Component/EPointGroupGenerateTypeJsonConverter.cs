using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A9E RID: 2718
	public class EPointGroupGenerateTypeJsonConverter : JsonConverter<EPointGroupGenerateType>
	{
		// Token: 0x06003BDB RID: 15323 RVA: 0x00099E40 File Offset: 0x00098040
		public override EPointGroupGenerateType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPointGroupGenerateType.Layer;
			}
			return EPointGroupGenerateTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BDC RID: 15324 RVA: 0x00099E64 File Offset: 0x00098064
		public override void Write(Utf8JsonWriter writer, EPointGroupGenerateType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
