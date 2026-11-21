using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001369 RID: 4969
	public class EBudgetCameraTypeJsonConverter : JsonConverter<EBudgetCameraType>
	{
		// Token: 0x06006FB4 RID: 28596 RVA: 0x00108F50 File Offset: 0x00107150
		public override EBudgetCameraType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBudgetCameraType.Role;
			}
			return EBudgetCameraTypeExtensions.FromString(@string);
		}

		// Token: 0x06006FB5 RID: 28597 RVA: 0x00108F74 File Offset: 0x00107174
		public override void Write(Utf8JsonWriter writer, EBudgetCameraType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
