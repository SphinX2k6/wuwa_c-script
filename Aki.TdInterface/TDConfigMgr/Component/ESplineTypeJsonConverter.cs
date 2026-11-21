using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE4 RID: 2788
	public class ESplineTypeJsonConverter : JsonConverter<ESplineType>
	{
		// Token: 0x06003D16 RID: 15638 RVA: 0x0009C870 File Offset: 0x0009AA70
		public override ESplineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineType.Common;
			}
			return ESplineTypeExtensions.FromString(@string);
		}

		// Token: 0x06003D17 RID: 15639 RVA: 0x0009C894 File Offset: 0x0009AA94
		public override void Write(Utf8JsonWriter writer, ESplineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
