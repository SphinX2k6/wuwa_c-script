using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200137D RID: 4989
	public class EEnableSystemTypeJsonConverter : JsonConverter<EEnableSystemType>
	{
		// Token: 0x0600700E RID: 28686 RVA: 0x0010B24C File Offset: 0x0010944C
		public override EEnableSystemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnableSystemType.GradingSystem;
			}
			return EEnableSystemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600700F RID: 28687 RVA: 0x0010B270 File Offset: 0x00109470
		public override void Write(Utf8JsonWriter writer, EEnableSystemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
