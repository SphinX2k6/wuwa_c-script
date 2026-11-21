using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x02005B0F RID: 23311
	public class ELevelGeneralConditionJsonConverter : JsonConverter<ELevelGeneralCondition>
	{
		// Token: 0x06039561 RID: 234849 RVA: 0x01016E6C File Offset: 0x0101506C
		public override ELevelGeneralCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelGeneralCondition.DistanceLess;
			}
			return ELevelGeneralConditionExtensions.FromString(@string);
		}

		// Token: 0x06039562 RID: 234850 RVA: 0x01016E90 File Offset: 0x01015090
		public override void Write(Utf8JsonWriter writer, ELevelGeneralCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
