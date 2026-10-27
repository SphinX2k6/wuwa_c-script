using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000987 RID: 2439
	public class ELevelAIBehaviourTypeJsonConverter : JsonConverter<ELevelAIBehaviourType>
	{
		// Token: 0x06003692 RID: 13970 RVA: 0x0008E2FC File Offset: 0x0008C4FC
		public override ELevelAIBehaviourType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelAIBehaviourType.Spline;
			}
			return ELevelAIBehaviourTypeExtensions.FromString(@string);
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x0008E320 File Offset: 0x0008C520
		public override void Write(Utf8JsonWriter writer, ELevelAIBehaviourType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
