using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200138B RID: 5003
	public class EInformationBoardTypeJsonConverter : JsonConverter<EInformationBoardType>
	{
		// Token: 0x0600704D RID: 28749 RVA: 0x0010B96C File Offset: 0x00109B6C
		public override EInformationBoardType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EInformationBoardType.DangoAbyss;
			}
			return EInformationBoardTypeExtensions.FromString(@string);
		}

		// Token: 0x0600704E RID: 28750 RVA: 0x0010B990 File Offset: 0x00109B90
		public override void Write(Utf8JsonWriter writer, EInformationBoardType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
