using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000957 RID: 2391
	public class EGridShapeJsonConverter : JsonConverter<EGridShape>
	{
		// Token: 0x060035BA RID: 13754 RVA: 0x0008C0A8 File Offset: 0x0008A2A8
		public override EGridShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGridShape.Vertical;
			}
			return EGridShapeExtensions.FromString(@string);
		}

		// Token: 0x060035BB RID: 13755 RVA: 0x0008C0CC File Offset: 0x0008A2CC
		public override void Write(Utf8JsonWriter writer, EGridShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
