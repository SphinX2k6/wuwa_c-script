using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ADE RID: 2782
	public class ESpecialNpcMarkTypeJsonConverter : JsonConverter<ESpecialNpcMarkType>
	{
		// Token: 0x06003CFB RID: 15611 RVA: 0x0009C1CC File Offset: 0x0009A3CC
		public override ESpecialNpcMarkType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecialNpcMarkType.TrafficLight;
			}
			return ESpecialNpcMarkTypeExtensions.FromString(@string);
		}

		// Token: 0x06003CFC RID: 15612 RVA: 0x0009C1F0 File Offset: 0x0009A3F0
		public override void Write(Utf8JsonWriter writer, ESpecialNpcMarkType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
