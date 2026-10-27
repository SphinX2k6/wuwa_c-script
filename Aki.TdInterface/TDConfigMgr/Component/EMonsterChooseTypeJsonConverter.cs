using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200099F RID: 2463
	public class EMonsterChooseTypeJsonConverter : JsonConverter<EMonsterChooseType>
	{
		// Token: 0x060036FE RID: 14078 RVA: 0x0008F0A8 File Offset: 0x0008D2A8
		public override EMonsterChooseType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMonsterChooseType.RandomPoolChoose;
			}
			return EMonsterChooseTypeExtensions.FromString(@string);
		}

		// Token: 0x060036FF RID: 14079 RVA: 0x0008F0CC File Offset: 0x0008D2CC
		public override void Write(Utf8JsonWriter writer, EMonsterChooseType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
