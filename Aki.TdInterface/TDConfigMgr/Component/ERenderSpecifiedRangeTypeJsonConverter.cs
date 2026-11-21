using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ABA RID: 2746
	public class ERenderSpecifiedRangeTypeJsonConverter : JsonConverter<ERenderSpecifiedRangeType>
	{
		// Token: 0x06003C59 RID: 15449 RVA: 0x0009AE9C File Offset: 0x0009909C
		public override ERenderSpecifiedRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERenderSpecifiedRangeType.FlowerBridge;
			}
			return ERenderSpecifiedRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003C5A RID: 15450 RVA: 0x0009AEC0 File Offset: 0x000990C0
		public override void Write(Utf8JsonWriter writer, ERenderSpecifiedRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
