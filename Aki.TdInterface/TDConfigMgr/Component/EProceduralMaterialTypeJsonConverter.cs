using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA4 RID: 2724
	public class EProceduralMaterialTypeJsonConverter : JsonConverter<EProceduralMaterialType>
	{
		// Token: 0x06003BF6 RID: 15350 RVA: 0x0009A144 File Offset: 0x00098344
		public override EProceduralMaterialType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProceduralMaterialType.CustomPrimitiveData;
			}
			return EProceduralMaterialTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BF7 RID: 15351 RVA: 0x0009A168 File Offset: 0x00098368
		public override void Write(Utf8JsonWriter writer, EProceduralMaterialType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
