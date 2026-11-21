using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099C RID: 2460
	public class EAnimalModelTypeJsonConverter : JsonConverter<EAnimalModelType>
	{
		// Token: 0x06003752 RID: 14162 RVA: 0x0008C5B0 File Offset: 0x0008A7B0
		public override EAnimalModelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAnimalModelType.Mesh;
			}
			return EAnimalModelTypeExtensions.FromString(@string);
		}

		// Token: 0x06003753 RID: 14163 RVA: 0x0008C5D4 File Offset: 0x0008A7D4
		public override void Write(Utf8JsonWriter writer, EAnimalModelType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
