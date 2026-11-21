using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002751 RID: 10065
	public class EVisualNovelOptionGroupTypeJsonConverter : JsonConverter<EVisualNovelOptionGroupType>
	{
		// Token: 0x0600D848 RID: 55368 RVA: 0x001F9828 File Offset: 0x001F7A28
		public override EVisualNovelOptionGroupType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelOptionGroupType.Normal;
			}
			return EVisualNovelOptionGroupTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D849 RID: 55369 RVA: 0x001F984C File Offset: 0x001F7A4C
		public override void Write(Utf8JsonWriter writer, EVisualNovelOptionGroupType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
