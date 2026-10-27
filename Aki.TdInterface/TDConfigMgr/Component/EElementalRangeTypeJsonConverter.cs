using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092F RID: 2351
	public class EElementalRangeTypeJsonConverter : JsonConverter<EElementalRangeType>
	{
		// Token: 0x06003506 RID: 13574 RVA: 0x0008A800 File Offset: 0x00088A00
		public override EElementalRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalRangeType.BaseShape;
			}
			return EElementalRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0008A824 File Offset: 0x00088A24
		public override void Write(Utf8JsonWriter writer, EElementalRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
