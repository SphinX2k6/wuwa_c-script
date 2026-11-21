using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009DC RID: 2524
	public class EElementalRangeTypeJsonConverter : JsonConverter<EElementalRangeType>
	{
		// Token: 0x06003872 RID: 14450 RVA: 0x00092380 File Offset: 0x00090580
		public override EElementalRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EElementalRangeType.BaseShape;
			}
			return EElementalRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003873 RID: 14451 RVA: 0x000923A4 File Offset: 0x000905A4
		public override void Write(Utf8JsonWriter writer, EElementalRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
