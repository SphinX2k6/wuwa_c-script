using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0C RID: 2572
	public class EGroupAiEcologyGameplayTypeJsonConverter : JsonConverter<EGroupAiEcologyGameplayType>
	{
		// Token: 0x0600394A RID: 14666 RVA: 0x000940D8 File Offset: 0x000922D8
		public override EGroupAiEcologyGameplayType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupAiEcologyGameplayType.FloatParade;
			}
			return EGroupAiEcologyGameplayTypeExtensions.FromString(@string);
		}

		// Token: 0x0600394B RID: 14667 RVA: 0x000940FC File Offset: 0x000922FC
		public override void Write(Utf8JsonWriter writer, EGroupAiEcologyGameplayType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
