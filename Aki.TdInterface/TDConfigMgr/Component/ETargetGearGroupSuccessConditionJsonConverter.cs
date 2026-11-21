using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF2 RID: 2802
	public class ETargetGearGroupSuccessConditionJsonConverter : JsonConverter<ETargetGearGroupSuccessCondition>
	{
		// Token: 0x06003D55 RID: 15701 RVA: 0x0009D0C0 File Offset: 0x0009B2C0
		public override ETargetGearGroupSuccessCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetGearGroupSuccessCondition.SameSpecificState;
			}
			return ETargetGearGroupSuccessConditionExtensions.FromString(@string);
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x0009D0E4 File Offset: 0x0009B2E4
		public override void Write(Utf8JsonWriter writer, ETargetGearGroupSuccessCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
