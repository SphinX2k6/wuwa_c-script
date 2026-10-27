using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098F RID: 2447
	public class ELiftBuffTypeJsonConverter : JsonConverter<ELiftBuffType>
	{
		// Token: 0x060036B6 RID: 14006 RVA: 0x0008E758 File Offset: 0x0008C958
		public override ELiftBuffType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELiftBuffType.DefaultLiftBuff;
			}
			return ELiftBuffTypeExtensions.FromString(@string);
		}

		// Token: 0x060036B7 RID: 14007 RVA: 0x0008E77C File Offset: 0x0008C97C
		public override void Write(Utf8JsonWriter writer, ELiftBuffType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
