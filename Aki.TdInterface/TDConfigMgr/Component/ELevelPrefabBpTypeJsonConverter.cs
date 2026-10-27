using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200098B RID: 2443
	public class ELevelPrefabBpTypeJsonConverter : JsonConverter<ELevelPrefabBpType>
	{
		// Token: 0x060036A4 RID: 13988 RVA: 0x0008E530 File Offset: 0x0008C730
		public override ELevelPrefabBpType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelPrefabBpType.Item;
			}
			return ELevelPrefabBpTypeExtensions.FromString(@string);
		}

		// Token: 0x060036A5 RID: 13989 RVA: 0x0008E554 File Offset: 0x0008C754
		public override void Write(Utf8JsonWriter writer, ELevelPrefabBpType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
