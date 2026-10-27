using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2B RID: 2603
	public class ETargetGearGroupFailureConditionJsonConverter : JsonConverter<ETargetGearGroupFailureCondition>
	{
		// Token: 0x06003974 RID: 14708 RVA: 0x00094604 File Offset: 0x00092804
		public override ETargetGearGroupFailureCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetGearGroupFailureCondition.ArbitraryState;
			}
			return ETargetGearGroupFailureConditionExtensions.FromString(@string);
		}

		// Token: 0x06003975 RID: 14709 RVA: 0x00094628 File Offset: 0x00092828
		public override void Write(Utf8JsonWriter writer, ETargetGearGroupFailureCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
