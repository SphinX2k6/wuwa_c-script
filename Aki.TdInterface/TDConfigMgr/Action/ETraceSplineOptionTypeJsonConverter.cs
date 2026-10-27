using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200247C RID: 9340
	public class ETraceSplineOptionTypeJsonConverter : JsonConverter<ETraceSplineOptionType>
	{
		// Token: 0x0600CAAE RID: 51886 RVA: 0x001DD570 File Offset: 0x001DB770
		public override ETraceSplineOptionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETraceSplineOptionType.Open;
			}
			return ETraceSplineOptionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CAAF RID: 51887 RVA: 0x001DD594 File Offset: 0x001DB794
		public override void Write(Utf8JsonWriter writer, ETraceSplineOptionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
