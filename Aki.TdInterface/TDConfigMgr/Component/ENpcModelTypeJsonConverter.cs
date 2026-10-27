using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B5 RID: 2485
	public class ENpcModelTypeJsonConverter : JsonConverter<ENpcModelType>
	{
		// Token: 0x06003761 RID: 14177 RVA: 0x0009005C File Offset: 0x0008E25C
		public override ENpcModelType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENpcModelType.Mesh;
			}
			return ENpcModelTypeExtensions.FromString(@string);
		}

		// Token: 0x06003762 RID: 14178 RVA: 0x00090080 File Offset: 0x0008E280
		public override void Write(Utf8JsonWriter writer, ENpcModelType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
