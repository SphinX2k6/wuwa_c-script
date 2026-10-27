using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BB RID: 4795
	public class EWarningPreformTypeJsonConverter : JsonConverter<EWarningPreformType>
	{
		// Token: 0x06006BF2 RID: 27634 RVA: 0x00103D2C File Offset: 0x00101F2C
		public override EWarningPreformType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWarningPreformType.FadeInScreen;
			}
			return EWarningPreformTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x00103D50 File Offset: 0x00101F50
		public override void Write(Utf8JsonWriter writer, EWarningPreformType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
