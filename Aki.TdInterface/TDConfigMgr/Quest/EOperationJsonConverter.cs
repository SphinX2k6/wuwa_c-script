using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200125D RID: 4701
	public class EOperationJsonConverter : JsonConverter<EOperation>
	{
		// Token: 0x06006A4B RID: 27211 RVA: 0x000FECE8 File Offset: 0x000FCEE8
		public override EOperation Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EOperation.DisableHLOD;
			}
			return EOperationExtensions.FromString(@string);
		}

		// Token: 0x06006A4C RID: 27212 RVA: 0x000FED0C File Offset: 0x000FCF0C
		public override void Write(Utf8JsonWriter writer, EOperation value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
