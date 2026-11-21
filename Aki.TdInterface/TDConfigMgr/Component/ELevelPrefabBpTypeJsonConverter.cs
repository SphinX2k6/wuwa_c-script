using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A3E RID: 2622
	public class ELevelPrefabBpTypeJsonConverter : JsonConverter<ELevelPrefabBpType>
	{
		// Token: 0x06003A2B RID: 14891 RVA: 0x0009649C File Offset: 0x0009469C
		public override ELevelPrefabBpType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELevelPrefabBpType.Item;
			}
			return ELevelPrefabBpTypeExtensions.FromString(@string);
		}

		// Token: 0x06003A2C RID: 14892 RVA: 0x000964C0 File Offset: 0x000946C0
		public override void Write(Utf8JsonWriter writer, ELevelPrefabBpType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
