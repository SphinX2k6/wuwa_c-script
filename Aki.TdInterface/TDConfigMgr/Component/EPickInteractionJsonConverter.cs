using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A96 RID: 2710
	public class EPickInteractionJsonConverter : JsonConverter<EPickInteraction>
	{
		// Token: 0x06003BB7 RID: 15287 RVA: 0x00099A1C File Offset: 0x00097C1C
		public override EPickInteraction Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPickInteraction.ChessmanInteract;
			}
			return EPickInteractionExtensions.FromString(@string);
		}

		// Token: 0x06003BB8 RID: 15288 RVA: 0x00099A40 File Offset: 0x00097C40
		public override void Write(Utf8JsonWriter writer, EPickInteraction value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
