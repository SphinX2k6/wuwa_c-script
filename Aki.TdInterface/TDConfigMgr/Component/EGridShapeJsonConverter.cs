using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0A RID: 2570
	public class EGridShapeJsonConverter : JsonConverter<EGridShape>
	{
		// Token: 0x06003941 RID: 14657 RVA: 0x00093FFC File Offset: 0x000921FC
		public override EGridShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGridShape.Vertical;
			}
			return EGridShapeExtensions.FromString(@string);
		}

		// Token: 0x06003942 RID: 14658 RVA: 0x00094020 File Offset: 0x00092220
		public override void Write(Utf8JsonWriter writer, EGridShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
