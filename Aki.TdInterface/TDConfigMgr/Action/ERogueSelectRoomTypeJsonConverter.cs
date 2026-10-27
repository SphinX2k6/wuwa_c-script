using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023F8 RID: 9208
	public class ERogueSelectRoomTypeJsonConverter : JsonConverter<ERogueSelectRoomType>
	{
		// Token: 0x0600C85C RID: 51292 RVA: 0x001D52D8 File Offset: 0x001D34D8
		public override ERogueSelectRoomType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueSelectRoomType.Role;
			}
			return ERogueSelectRoomTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C85D RID: 51293 RVA: 0x001D52FC File Offset: 0x001D34FC
		public override void Write(Utf8JsonWriter writer, ERogueSelectRoomType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
