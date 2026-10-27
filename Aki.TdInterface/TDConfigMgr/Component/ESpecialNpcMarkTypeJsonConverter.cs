using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A19 RID: 2585
	public class ESpecialNpcMarkTypeJsonConverter : JsonConverter<ESpecialNpcMarkType>
	{
		// Token: 0x06003923 RID: 14627 RVA: 0x00093898 File Offset: 0x00091A98
		public override ESpecialNpcMarkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialNpcMarkType.TrafficLight;
			}
			return ESpecialNpcMarkTypeExtensions.FromString(@string);
		}

		// Token: 0x06003924 RID: 14628 RVA: 0x000938BC File Offset: 0x00091ABC
		public override void Write(Utf8JsonWriter writer, ESpecialNpcMarkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
