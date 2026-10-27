using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A4B RID: 2635
	public class EWuWaGoGridRotationTypeJsonConverter : JsonConverter<EWuWaGoGridRotationType>
	{
		// Token: 0x06003A04 RID: 14852 RVA: 0x00095C0C File Offset: 0x00093E0C
		public override EWuWaGoGridRotationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWuWaGoGridRotationType.Front;
			}
			return EWuWaGoGridRotationTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A05 RID: 14853 RVA: 0x00095C30 File Offset: 0x00093E30
		public override void Write(Utf8JsonWriter writer, EWuWaGoGridRotationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
