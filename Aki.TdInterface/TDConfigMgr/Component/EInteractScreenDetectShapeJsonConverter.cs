using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2C RID: 2604
	public class EInteractScreenDetectShapeJsonConverter : JsonConverter<EInteractScreenDetectShape>
	{
		// Token: 0x060039DA RID: 14810 RVA: 0x000959E8 File Offset: 0x00093BE8
		public override EInteractScreenDetectShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractScreenDetectShape.Circle;
			}
			return EInteractScreenDetectShapeExtensions.FromString(@string);
		}

		// Token: 0x060039DB RID: 14811 RVA: 0x00095A0C File Offset: 0x00093C0C
		public override void Write(Utf8JsonWriter writer, EInteractScreenDetectShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
