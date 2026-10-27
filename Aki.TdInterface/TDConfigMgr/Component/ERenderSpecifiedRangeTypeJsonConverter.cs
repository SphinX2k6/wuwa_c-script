using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F5 RID: 2549
	public class ERenderSpecifiedRangeTypeJsonConverter : JsonConverter<ERenderSpecifiedRangeType>
	{
		// Token: 0x06003881 RID: 14465 RVA: 0x000925AC File Offset: 0x000907AC
		public override ERenderSpecifiedRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERenderSpecifiedRangeType.FlowerBridge;
			}
			return ERenderSpecifiedRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003882 RID: 14466 RVA: 0x000925D0 File Offset: 0x000907D0
		public override void Write(Utf8JsonWriter writer, ERenderSpecifiedRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
