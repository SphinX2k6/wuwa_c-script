using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200267D RID: 9853
	public class ERandomPrefabTypeJsonConverter : JsonConverter<ERandomPrefabType>
	{
		// Token: 0x0600D48E RID: 54414 RVA: 0x001EE13C File Offset: 0x001EC33C
		public override ERandomPrefabType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERandomPrefabType.Rogue;
			}
			return ERandomPrefabTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D48F RID: 54415 RVA: 0x001EE160 File Offset: 0x001EC360
		public override void Write(Utf8JsonWriter writer, ERandomPrefabType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
