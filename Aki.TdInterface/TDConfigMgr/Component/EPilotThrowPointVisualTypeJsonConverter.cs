using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D5 RID: 2517
	public class EPilotThrowPointVisualTypeJsonConverter : JsonConverter<EPilotThrowPointVisualType>
	{
		// Token: 0x060037F1 RID: 14321 RVA: 0x000913C8 File Offset: 0x0008F5C8
		public override EPilotThrowPointVisualType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPilotThrowPointVisualType.Normal;
			}
			return EPilotThrowPointVisualTypeExtensions.FromString(@string);
		}

		// Token: 0x060037F2 RID: 14322 RVA: 0x000913EC File Offset: 0x0008F5EC
		public override void Write(Utf8JsonWriter writer, EPilotThrowPointVisualType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
