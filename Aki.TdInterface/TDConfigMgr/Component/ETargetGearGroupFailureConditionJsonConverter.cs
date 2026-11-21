using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF0 RID: 2800
	public class ETargetGearGroupFailureConditionJsonConverter : JsonConverter<ETargetGearGroupFailureCondition>
	{
		// Token: 0x06003D4C RID: 15692 RVA: 0x0009CF38 File Offset: 0x0009B138
		public override ETargetGearGroupFailureCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetGearGroupFailureCondition.ArbitraryState;
			}
			return ETargetGearGroupFailureConditionExtensions.FromString(@string);
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x0009CF5C File Offset: 0x0009B15C
		public override void Write(Utf8JsonWriter writer, ETargetGearGroupFailureCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
