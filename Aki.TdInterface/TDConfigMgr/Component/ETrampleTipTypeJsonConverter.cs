using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A41 RID: 2625
	public class ETrampleTipTypeJsonConverter : JsonConverter<ETrampleTipType>
	{
		// Token: 0x060039D7 RID: 14807 RVA: 0x0009525C File Offset: 0x0009345C
		public override ETrampleTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrampleTipType.CountDownTextTip;
			}
			return ETrampleTipTypeExtensions.FromString(@string);
		}

		// Token: 0x060039D8 RID: 14808 RVA: 0x00095280 File Offset: 0x00093480
		public override void Write(Utf8JsonWriter writer, ETrampleTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
