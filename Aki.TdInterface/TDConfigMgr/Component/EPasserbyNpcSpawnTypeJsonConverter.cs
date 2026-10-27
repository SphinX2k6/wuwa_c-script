using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009C1 RID: 2497
	public class EPasserbyNpcSpawnTypeJsonConverter : JsonConverter<EPasserbyNpcSpawnType>
	{
		// Token: 0x06003797 RID: 14231 RVA: 0x00090914 File Offset: 0x0008EB14
		public override EPasserbyNpcSpawnType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcSpawnType.FixInterval;
			}
			return EPasserbyNpcSpawnTypeExtensions.FromString(@string);
		}

		// Token: 0x06003798 RID: 14232 RVA: 0x00090938 File Offset: 0x0008EB38
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcSpawnType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
