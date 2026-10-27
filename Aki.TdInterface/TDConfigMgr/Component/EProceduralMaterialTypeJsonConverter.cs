using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DF RID: 2527
	public class EProceduralMaterialTypeJsonConverter : JsonConverter<EProceduralMaterialType>
	{
		// Token: 0x0600381E RID: 14366 RVA: 0x00091884 File Offset: 0x0008FA84
		public override EProceduralMaterialType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProceduralMaterialType.CustomPrimitiveData;
			}
			return EProceduralMaterialTypeExtensions.FromString(@string);
		}

		// Token: 0x0600381F RID: 14367 RVA: 0x000918A8 File Offset: 0x0008FAA8
		public override void Write(Utf8JsonWriter writer, EProceduralMaterialType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
