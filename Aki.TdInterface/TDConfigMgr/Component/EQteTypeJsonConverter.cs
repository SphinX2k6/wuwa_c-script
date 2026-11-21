using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AAC RID: 2732
	public class EQteTypeJsonConverter : JsonConverter<EQteType>
	{
		// Token: 0x06003C1A RID: 15386 RVA: 0x0009A5C8 File Offset: 0x000987C8
		public override EQteType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQteType.SingleBtn;
			}
			return EQteTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C1B RID: 15387 RVA: 0x0009A5EC File Offset: 0x000987EC
		public override void Write(Utf8JsonWriter writer, EQteType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
