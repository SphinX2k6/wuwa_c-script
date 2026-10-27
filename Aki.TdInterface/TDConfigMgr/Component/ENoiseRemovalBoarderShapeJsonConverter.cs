using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AF RID: 2479
	public class ENoiseRemovalBoarderShapeJsonConverter : JsonConverter<ENoiseRemovalBoarderShape>
	{
		// Token: 0x06003746 RID: 14150 RVA: 0x0008FC88 File Offset: 0x0008DE88
		public override ENoiseRemovalBoarderShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENoiseRemovalBoarderShape.Box;
			}
			return ENoiseRemovalBoarderShapeExtensions.FromString(@string);
		}

		// Token: 0x06003747 RID: 14151 RVA: 0x0008FCAC File Offset: 0x0008DEAC
		public override void Write(Utf8JsonWriter writer, ENoiseRemovalBoarderShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
