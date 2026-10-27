using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000999 RID: 2457
	public class EMechascoutDragTypeJsonConverter : JsonConverter<EMechascoutDragType>
	{
		// Token: 0x060036E3 RID: 14051 RVA: 0x0008ED30 File Offset: 0x0008CF30
		public override EMechascoutDragType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMechascoutDragType.Instant;
			}
			return EMechascoutDragTypeExtensions.FromString(@string);
		}

		// Token: 0x060036E4 RID: 14052 RVA: 0x0008ED54 File Offset: 0x0008CF54
		public override void Write(Utf8JsonWriter writer, EMechascoutDragType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
