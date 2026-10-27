using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009E3 RID: 2531
	public class EProgressBarControlTypeJsonConverter : JsonConverter<EProgressBarControlType>
	{
		// Token: 0x06003830 RID: 14384 RVA: 0x00091B50 File Offset: 0x0008FD50
		public override EProgressBarControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProgressBarControlType.CaptureStrategicPoint;
			}
			return EProgressBarControlTypeExtensions.FromString(@string);
		}

		// Token: 0x06003831 RID: 14385 RVA: 0x00091B74 File Offset: 0x0008FD74
		public override void Write(Utf8JsonWriter writer, EProgressBarControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
