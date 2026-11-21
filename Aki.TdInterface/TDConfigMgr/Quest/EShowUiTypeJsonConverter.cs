using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013CD RID: 5069
	public class EShowUiTypeJsonConverter : JsonConverter<EShowUiType>
	{
		// Token: 0x06007176 RID: 29046 RVA: 0x0010EFD8 File Offset: 0x0010D1D8
		public override EShowUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EShowUiType.All;
			}
			return EShowUiTypeExtensions.FromString(@string);
		}

		// Token: 0x06007177 RID: 29047 RVA: 0x0010EFFC File Offset: 0x0010D1FC
		public override void Write(Utf8JsonWriter writer, EShowUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
