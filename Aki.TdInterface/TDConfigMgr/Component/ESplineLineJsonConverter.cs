using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AE2 RID: 2786
	public class ESplineLineJsonConverter : JsonConverter<ESplineLine>
	{
		// Token: 0x06003D0D RID: 15629 RVA: 0x0009C430 File Offset: 0x0009A630
		public override ESplineLine Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineLine.Linear;
			}
			return ESplineLineExtensions.FromString(@string);
		}

		// Token: 0x06003D0E RID: 15630 RVA: 0x0009C454 File Offset: 0x0009A654
		public override void Write(Utf8JsonWriter writer, ESplineLine value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
