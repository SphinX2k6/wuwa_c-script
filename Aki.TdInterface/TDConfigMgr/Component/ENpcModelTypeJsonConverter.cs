using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A6A RID: 2666
	public class ENpcModelTypeJsonConverter : JsonConverter<ENpcModelType>
	{
		// Token: 0x06003AF1 RID: 15089 RVA: 0x00098194 File Offset: 0x00096394
		public override ENpcModelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcModelType.Mesh;
			}
			return ENpcModelTypeExtensions.FromString(@string);
		}

		// Token: 0x06003AF2 RID: 15090 RVA: 0x000981B8 File Offset: 0x000963B8
		public override void Write(Utf8JsonWriter writer, ENpcModelType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
