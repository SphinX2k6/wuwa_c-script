using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F3 RID: 2291
	public class EAnimalModelTypeJsonConverter : JsonConverter<EAnimalModelType>
	{
		// Token: 0x060033F8 RID: 13304 RVA: 0x00084D84 File Offset: 0x00082F84
		public override EAnimalModelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAnimalModelType.Mesh;
			}
			return EAnimalModelTypeExtensions.FromString(@string);
		}

		// Token: 0x060033F9 RID: 13305 RVA: 0x00084DA8 File Offset: 0x00082FA8
		public override void Write(Utf8JsonWriter writer, EAnimalModelType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
