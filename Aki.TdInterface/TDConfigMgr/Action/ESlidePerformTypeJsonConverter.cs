using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002420 RID: 9248
	public class ESlidePerformTypeJsonConverter : JsonConverter<ESlidePerformType>
	{
		// Token: 0x0600C910 RID: 51472 RVA: 0x001D71EC File Offset: 0x001D53EC
		public override ESlidePerformType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlidePerformType.SlopeSlide;
			}
			return ESlidePerformTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C911 RID: 51473 RVA: 0x001D7210 File Offset: 0x001D5410
		public override void Write(Utf8JsonWriter writer, ESlidePerformType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
