using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3A RID: 2618
	public class ELevelAIBehaviourTypeJsonConverter : JsonConverter<ELevelAIBehaviourType>
	{
		// Token: 0x06003A19 RID: 14873 RVA: 0x00096268 File Offset: 0x00094468
		public override ELevelAIBehaviourType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelAIBehaviourType.Spline;
			}
			return ELevelAIBehaviourTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A1A RID: 14874 RVA: 0x0009628C File Offset: 0x0009448C
		public override void Write(Utf8JsonWriter writer, ELevelAIBehaviourType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
