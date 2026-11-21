using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A9C RID: 2716
	public class EPointChooseTypeJsonConverter : JsonConverter<EPointChooseType>
	{
		// Token: 0x06003BD2 RID: 15314 RVA: 0x00099D64 File Offset: 0x00097F64
		public override EPointChooseType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPointChooseType.SpawnMonsterPoint;
			}
			return EPointChooseTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BD3 RID: 15315 RVA: 0x00099D88 File Offset: 0x00097F88
		public override void Write(Utf8JsonWriter writer, EPointChooseType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
