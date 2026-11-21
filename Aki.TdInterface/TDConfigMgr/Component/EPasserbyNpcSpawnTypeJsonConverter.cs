using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A82 RID: 2690
	public class EPasserbyNpcSpawnTypeJsonConverter : JsonConverter<EPasserbyNpcSpawnType>
	{
		// Token: 0x06003B5D RID: 15197 RVA: 0x00098FE4 File Offset: 0x000971E4
		public override EPasserbyNpcSpawnType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcSpawnType.FixInterval;
			}
			return EPasserbyNpcSpawnTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B5E RID: 15198 RVA: 0x00099008 File Offset: 0x00097208
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcSpawnType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
