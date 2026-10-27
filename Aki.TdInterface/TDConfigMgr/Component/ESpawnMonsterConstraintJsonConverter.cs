using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A13 RID: 2579
	public class ESpawnMonsterConstraintJsonConverter : JsonConverter<ESpawnMonsterConstraint>
	{
		// Token: 0x06003908 RID: 14600 RVA: 0x000935CC File Offset: 0x000917CC
		public override ESpawnMonsterConstraint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
			}
			return ESpawnMonsterConstraintExtensions.FromString(@string);
		}

		// Token: 0x06003909 RID: 14601 RVA: 0x000935F0 File Offset: 0x000917F0
		public override void Write(Utf8JsonWriter writer, ESpawnMonsterConstraint value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
