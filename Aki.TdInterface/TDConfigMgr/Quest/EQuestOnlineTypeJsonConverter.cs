using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013AF RID: 5039
	public class EQuestOnlineTypeJsonConverter : JsonConverter<EQuestOnlineType>
	{
		// Token: 0x060070EF RID: 28911 RVA: 0x0010D50C File Offset: 0x0010B70C
		public override EQuestOnlineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestOnlineType.SingleHangUpOnline;
			}
			return EQuestOnlineTypeExtensions.FromString(@string);
		}

		// Token: 0x060070F0 RID: 28912 RVA: 0x0010D530 File Offset: 0x0010B730
		public override void Write(Utf8JsonWriter writer, EQuestOnlineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
