using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000979 RID: 2425
	public class EInteractScreenDetectShapeJsonConverter : JsonConverter<EInteractScreenDetectShape>
	{
		// Token: 0x06003653 RID: 13907 RVA: 0x0008DA7C File Offset: 0x0008BC7C
		public override EInteractScreenDetectShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInteractScreenDetectShape.Circle;
			}
			return EInteractScreenDetectShapeExtensions.FromString(@string);
		}

		// Token: 0x06003654 RID: 13908 RVA: 0x0008DAA0 File Offset: 0x0008BCA0
		public override void Write(Utf8JsonWriter writer, EInteractScreenDetectShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
