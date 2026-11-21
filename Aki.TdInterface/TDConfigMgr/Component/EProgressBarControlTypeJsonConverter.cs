using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AA8 RID: 2728
	public class EProgressBarControlTypeJsonConverter : JsonConverter<EProgressBarControlType>
	{
		// Token: 0x06003C08 RID: 15368 RVA: 0x0009A410 File Offset: 0x00098610
		public override EProgressBarControlType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProgressBarControlType.CaptureStrategicPoint;
			}
			return EProgressBarControlTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C09 RID: 15369 RVA: 0x0009A434 File Offset: 0x00098634
		public override void Write(Utf8JsonWriter writer, EProgressBarControlType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
