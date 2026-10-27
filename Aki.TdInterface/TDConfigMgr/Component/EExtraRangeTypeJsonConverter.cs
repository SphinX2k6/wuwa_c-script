using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000943 RID: 2371
	public class EExtraRangeTypeJsonConverter : JsonConverter<EExtraRangeType>
	{
		// Token: 0x06003560 RID: 13664 RVA: 0x0008B6F8 File Offset: 0x000898F8
		public override EExtraRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExtraRangeType.SunSpiritBlock;
			}
			return EExtraRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003561 RID: 13665 RVA: 0x0008B71C File Offset: 0x0008991C
		public override void Write(Utf8JsonWriter writer, EExtraRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
