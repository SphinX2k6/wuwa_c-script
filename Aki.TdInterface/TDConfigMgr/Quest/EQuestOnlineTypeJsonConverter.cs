using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200126F RID: 4719
	public class EQuestOnlineTypeJsonConverter : JsonConverter<EQuestOnlineType>
	{
		// Token: 0x06006A9C RID: 27292 RVA: 0x000FF8E0 File Offset: 0x000FDAE0
		public override EQuestOnlineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuestOnlineType.SingleHangUpOnline;
			}
			return EQuestOnlineTypeExtensions.FromString(@string);
		}

		// Token: 0x06006A9D RID: 27293 RVA: 0x000FF904 File Offset: 0x000FDB04
		public override void Write(Utf8JsonWriter writer, EQuestOnlineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
