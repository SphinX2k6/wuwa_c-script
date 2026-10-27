using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002486 RID: 9350
	public class ETrapDefensePlayerOperationTypeJsonConverter : JsonConverter<ETrapDefensePlayerOperationType>
	{
		// Token: 0x0600CADB RID: 51931 RVA: 0x001DDBC8 File Offset: 0x001DBDC8
		public override ETrapDefensePlayerOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefensePlayerOperationType.SpawnMonster;
			}
			return ETrapDefensePlayerOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CADC RID: 51932 RVA: 0x001DDBEC File Offset: 0x001DBDEC
		public override void Write(Utf8JsonWriter writer, ETrapDefensePlayerOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
