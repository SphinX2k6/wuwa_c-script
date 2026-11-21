using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099A RID: 2458
	public class EAkEventTypeJsonConverter : JsonConverter<EAkEventType>
	{
		// Token: 0x06003749 RID: 14153 RVA: 0x0008C4D4 File Offset: 0x0008A6D4
		public override EAkEventType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EAkEventType.Point;
			}
			return EAkEventTypeExtensions.FromString(@string);
		}

		// Token: 0x0600374A RID: 14154 RVA: 0x0008C4F8 File Offset: 0x0008A6F8
		public override void Write(Utf8JsonWriter writer, EAkEventType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
