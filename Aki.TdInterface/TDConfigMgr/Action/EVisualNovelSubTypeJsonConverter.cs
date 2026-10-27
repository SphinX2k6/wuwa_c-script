using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B8 RID: 9400
	public class EVisualNovelSubTypeJsonConverter : JsonConverter<EVisualNovelSubType>
	{
		// Token: 0x0600CBBC RID: 52156 RVA: 0x001DFFD8 File Offset: 0x001DE1D8
		public override EVisualNovelSubType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelSubType.SolarSchool;
			}
			return EVisualNovelSubTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBBD RID: 52157 RVA: 0x001DFFFC File Offset: 0x001DE1FC
		public override void Write(Utf8JsonWriter writer, EVisualNovelSubType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
