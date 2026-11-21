using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002729 RID: 10025
	public class ETrapDefensePlayerOperationTypeJsonConverter : JsonConverter<ETrapDefensePlayerOperationType>
	{
		// Token: 0x0600D794 RID: 55188 RVA: 0x001F7D90 File Offset: 0x001F5F90
		public override ETrapDefensePlayerOperationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETrapDefensePlayerOperationType.SpawnMonster;
			}
			return ETrapDefensePlayerOperationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D795 RID: 55189 RVA: 0x001F7DB4 File Offset: 0x001F5FB4
		public override void Write(Utf8JsonWriter writer, ETrapDefensePlayerOperationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
