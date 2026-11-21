using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000B06 RID: 2822
	public class ETrampleTipTypeJsonConverter : JsonConverter<ETrampleTipType>
	{
		// Token: 0x06003DAF RID: 15791 RVA: 0x0009DBC8 File Offset: 0x0009BDC8
		public override ETrampleTipType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrampleTipType.CountDownTextTip;
			}
			return ETrampleTipTypeExtensions.FromString(@string);
		}

		// Token: 0x06003DB0 RID: 15792 RVA: 0x0009DBEC File Offset: 0x0009BDEC
		public override void Write(Utf8JsonWriter writer, ETrampleTipType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
