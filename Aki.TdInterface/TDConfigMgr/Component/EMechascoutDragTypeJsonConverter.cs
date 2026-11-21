using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4C RID: 2636
	public class EMechascoutDragTypeJsonConverter : JsonConverter<EMechascoutDragType>
	{
		// Token: 0x06003A6A RID: 14954 RVA: 0x00096C9C File Offset: 0x00094E9C
		public override EMechascoutDragType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechascoutDragType.Instant;
			}
			return EMechascoutDragTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A6B RID: 14955 RVA: 0x00096CC0 File Offset: 0x00094EC0
		public override void Write(Utf8JsonWriter writer, EMechascoutDragType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
