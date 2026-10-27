using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200094B RID: 2379
	public class EFillTypeJsonConverter : JsonConverter<EFillType>
	{
		// Token: 0x06003584 RID: 13700 RVA: 0x0008BB10 File Offset: 0x00089D10
		public override EFillType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFillType.Fixed;
			}
			return EFillTypeExtensions.FromString(@string);
		}

		// Token: 0x06003585 RID: 13701 RVA: 0x0008BB34 File Offset: 0x00089D34
		public override void Write(Utf8JsonWriter writer, EFillType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
