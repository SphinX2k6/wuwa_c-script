using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.LevelGamePlay
{
	// Token: 0x020069B3 RID: 27059
	public class ELevelGeneralConditionJsonConverter : JsonConverter<ELevelGeneralCondition>
	{
		// Token: 0x06043529 RID: 275753 RVA: 0x01072A24 File Offset: 0x01070C24
		public override ELevelGeneralCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelGeneralCondition.DistanceLess;
			}
			return ELevelGeneralConditionExtensions.FromString(@string);
		}

		// Token: 0x0604352A RID: 275754 RVA: 0x01072A48 File Offset: 0x01070C48
		public override void Write(Utf8JsonWriter writer, ELevelGeneralCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
