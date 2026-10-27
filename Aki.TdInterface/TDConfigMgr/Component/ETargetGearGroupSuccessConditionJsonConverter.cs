using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A2D RID: 2605
	public class ETargetGearGroupSuccessConditionJsonConverter : JsonConverter<ETargetGearGroupSuccessCondition>
	{
		// Token: 0x0600397D RID: 14717 RVA: 0x0009478C File Offset: 0x0009298C
		public override ETargetGearGroupSuccessCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETargetGearGroupSuccessCondition.SameSpecificState;
			}
			return ETargetGearGroupSuccessConditionExtensions.FromString(@string);
		}

		// Token: 0x0600397E RID: 14718 RVA: 0x000947B0 File Offset: 0x000929B0
		public override void Write(Utf8JsonWriter writer, ETargetGearGroupSuccessCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
