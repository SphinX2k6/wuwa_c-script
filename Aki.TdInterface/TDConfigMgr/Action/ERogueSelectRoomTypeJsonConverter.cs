using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200268F RID: 9871
	public class ERogueSelectRoomTypeJsonConverter : JsonConverter<ERogueSelectRoomType>
	{
		// Token: 0x0600D4DF RID: 54495 RVA: 0x001EEA84 File Offset: 0x001ECC84
		public override ERogueSelectRoomType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueSelectRoomType.Role;
			}
			return ERogueSelectRoomTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D4E0 RID: 54496 RVA: 0x001EEAA8 File Offset: 0x001ECCA8
		public override void Write(Utf8JsonWriter writer, ERogueSelectRoomType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
