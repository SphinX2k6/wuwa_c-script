using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013D5 RID: 5077
	public class ESpecificDeadMonsterTypeJsonConverter : JsonConverter<ESpecificDeadMonsterType>
	{
		// Token: 0x0600719A RID: 29082 RVA: 0x0010F470 File Offset: 0x0010D670
		public override ESpecificDeadMonsterType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESpecificDeadMonsterType.LastDead;
			}
			return ESpecificDeadMonsterTypeExtensions.FromString(@string);
		}

		// Token: 0x0600719B RID: 29083 RVA: 0x0010F494 File Offset: 0x0010D694
		public override void Write(Utf8JsonWriter writer, ESpecificDeadMonsterType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
