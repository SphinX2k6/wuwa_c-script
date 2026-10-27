using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020008F1 RID: 2289
	public class EAkEventTypeJsonConverter : JsonConverter<EAkEventType>
	{
		// Token: 0x060033EF RID: 13295 RVA: 0x00084CA8 File Offset: 0x00082EA8
		public override EAkEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAkEventType.Point;
			}
			return EAkEventTypeExtensions.FromString(@string);
		}

		// Token: 0x060033F0 RID: 13296 RVA: 0x00084CCC File Offset: 0x00082ECC
		public override void Write(Utf8JsonWriter writer, EAkEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
