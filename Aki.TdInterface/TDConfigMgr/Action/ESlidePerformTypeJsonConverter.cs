using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026BF RID: 9919
	public class ESlidePerformTypeJsonConverter : JsonConverter<ESlidePerformType>
	{
		// Token: 0x0600D5B7 RID: 54711 RVA: 0x001F0EC0 File Offset: 0x001EF0C0
		public override ESlidePerformType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESlidePerformType.SlopeSlide;
			}
			return ESlidePerformTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D5B8 RID: 54712 RVA: 0x001F0EE4 File Offset: 0x001EF0E4
		public override void Write(Utf8JsonWriter writer, ESlidePerformType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
