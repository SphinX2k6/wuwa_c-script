using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002288 RID: 8840
	public class EActionMontageTypeJsonConverter : JsonConverter<EActionMontageType>
	{
		// Token: 0x0600C1E4 RID: 49636 RVA: 0x001C4F34 File Offset: 0x001C3134
		public override EActionMontageType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActionMontageType.Normal;
			}
			return EActionMontageTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C1E5 RID: 49637 RVA: 0x001C4F58 File Offset: 0x001C3158
		public override void Write(Utf8JsonWriter writer, EActionMontageType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
