using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001401 RID: 5121
	public class EWarningPreformTypeJsonConverter : JsonConverter<EWarningPreformType>
	{
		// Token: 0x06007260 RID: 29280 RVA: 0x00111CF4 File Offset: 0x0010FEF4
		public override EWarningPreformType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWarningPreformType.FadeInScreen;
			}
			return EWarningPreformTypeExtensions.FromString(@string);
		}

		// Token: 0x06007261 RID: 29281 RVA: 0x00111D18 File Offset: 0x0010FF18
		public override void Write(Utf8JsonWriter writer, EWarningPreformType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
