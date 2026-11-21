using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AD8 RID: 2776
	public class ESpawnMonsterConstraintJsonConverter : JsonConverter<ESpawnMonsterConstraint>
	{
		// Token: 0x06003CE0 RID: 15584 RVA: 0x0009BEBC File Offset: 0x0009A0BC
		public override ESpawnMonsterConstraint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpawnMonsterConstraint.CharacterForwardAnnularSector;
			}
			return ESpawnMonsterConstraintExtensions.FromString(@string);
		}

		// Token: 0x06003CE1 RID: 15585 RVA: 0x0009BEE0 File Offset: 0x0009A0E0
		public override void Write(Utf8JsonWriter writer, ESpawnMonsterConstraint value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
