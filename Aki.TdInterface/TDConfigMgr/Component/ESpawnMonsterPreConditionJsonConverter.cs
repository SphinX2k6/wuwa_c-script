using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000ADA RID: 2778
	public class ESpawnMonsterPreConditionJsonConverter : JsonConverter<ESpawnMonsterPreCondition>
	{
		// Token: 0x06003CE9 RID: 15593 RVA: 0x0009BF98 File Offset: 0x0009A198
		public override ESpawnMonsterPreCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpawnMonsterPreCondition.DependOnPreceding;
			}
			return ESpawnMonsterPreConditionExtensions.FromString(@string);
		}

		// Token: 0x06003CEA RID: 15594 RVA: 0x0009BFBC File Offset: 0x0009A1BC
		public override void Write(Utf8JsonWriter writer, ESpawnMonsterPreCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
