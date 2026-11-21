using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B9 RID: 5049
	public class ERecallDataTypeJsonConverter : JsonConverter<ERecallDataType>
	{
		// Token: 0x0600711C RID: 28956 RVA: 0x0010DDE8 File Offset: 0x0010BFE8
		public override ERecallDataType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERecallDataType.LevelPlay;
			}
			return ERecallDataTypeExtensions.FromString(@string);
		}

		// Token: 0x0600711D RID: 28957 RVA: 0x0010DE0C File Offset: 0x0010C00C
		public override void Write(Utf8JsonWriter writer, ERecallDataType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
