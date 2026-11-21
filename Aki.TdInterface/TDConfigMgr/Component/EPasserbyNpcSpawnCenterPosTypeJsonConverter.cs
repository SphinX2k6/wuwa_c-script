using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A80 RID: 2688
	public class EPasserbyNpcSpawnCenterPosTypeJsonConverter : JsonConverter<EPasserbyNpcSpawnCenterPosType>
	{
		// Token: 0x06003B54 RID: 15188 RVA: 0x00098ED0 File Offset: 0x000970D0
		public override EPasserbyNpcSpawnCenterPosType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcSpawnCenterPosType.Self;
			}
			return EPasserbyNpcSpawnCenterPosTypeExtensions.FromString(@string);
		}

		// Token: 0x06003B55 RID: 15189 RVA: 0x00098EF4 File Offset: 0x000970F4
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcSpawnCenterPosType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
