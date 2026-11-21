using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F2 RID: 2546
	public class EExtraRangeTypeJsonConverter : JsonConverter<EExtraRangeType>
	{
		// Token: 0x060038D5 RID: 14549 RVA: 0x000933B0 File Offset: 0x000915B0
		public override EExtraRangeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EExtraRangeType.SunSpiritBlock;
			}
			return EExtraRangeTypeExtensions.FromString(@string);
		}

		// Token: 0x060038D6 RID: 14550 RVA: 0x000933D4 File Offset: 0x000915D4
		public override void Write(Utf8JsonWriter writer, EExtraRangeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
