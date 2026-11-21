using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A64 RID: 2660
	public class ENoiseRemovalBoarderShapeJsonConverter : JsonConverter<ENoiseRemovalBoarderShape>
	{
		// Token: 0x06003AD6 RID: 15062 RVA: 0x00097D7C File Offset: 0x00095F7C
		public override ENoiseRemovalBoarderShape Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENoiseRemovalBoarderShape.Box;
			}
			return ENoiseRemovalBoarderShapeExtensions.FromString(@string);
		}

		// Token: 0x06003AD7 RID: 15063 RVA: 0x00097DA0 File Offset: 0x00095FA0
		public override void Write(Utf8JsonWriter writer, ENoiseRemovalBoarderShape value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
