using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A1D RID: 2589
	public class ESplineLineJsonConverter : JsonConverter<ESplineLine>
	{
		// Token: 0x06003935 RID: 14645 RVA: 0x00093AFC File Offset: 0x00091CFC
		public override ESplineLine Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESplineLine.Linear;
			}
			return ESplineLineExtensions.FromString(@string);
		}

		// Token: 0x06003936 RID: 14646 RVA: 0x00093B20 File Offset: 0x00091D20
		public override void Write(Utf8JsonWriter writer, ESplineLine value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
