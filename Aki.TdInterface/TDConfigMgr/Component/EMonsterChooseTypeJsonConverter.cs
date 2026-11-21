using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A52 RID: 2642
	public class EMonsterChooseTypeJsonConverter : JsonConverter<EMonsterChooseType>
	{
		// Token: 0x06003A85 RID: 14981 RVA: 0x00097058 File Offset: 0x00095258
		public override EMonsterChooseType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterChooseType.RandomPoolChoose;
			}
			return EMonsterChooseTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A86 RID: 14982 RVA: 0x0009707C File Offset: 0x0009527C
		public override void Write(Utf8JsonWriter writer, EMonsterChooseType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
