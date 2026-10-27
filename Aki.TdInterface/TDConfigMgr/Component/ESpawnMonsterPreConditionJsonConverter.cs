using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A15 RID: 2581
	public class ESpawnMonsterPreConditionJsonConverter : JsonConverter<ESpawnMonsterPreCondition>
	{
		// Token: 0x06003911 RID: 14609 RVA: 0x000936A8 File Offset: 0x000918A8
		public override ESpawnMonsterPreCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpawnMonsterPreCondition.DependOnPreceding;
			}
			return ESpawnMonsterPreConditionExtensions.FromString(@string);
		}

		// Token: 0x06003912 RID: 14610 RVA: 0x000936CC File Offset: 0x000918CC
		public override void Write(Utf8JsonWriter writer, ESpawnMonsterPreCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
