using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000959 RID: 2393
	public class EGroupAiEcologyGameplayTypeJsonConverter : JsonConverter<EGroupAiEcologyGameplayType>
	{
		// Token: 0x060035C3 RID: 13763 RVA: 0x0008C184 File Offset: 0x0008A384
		public override EGroupAiEcologyGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiEcologyGameplayType.FloatParade;
			}
			return EGroupAiEcologyGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x0008C1A8 File Offset: 0x0008A3A8
		public override void Write(Utf8JsonWriter writer, EGroupAiEcologyGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
