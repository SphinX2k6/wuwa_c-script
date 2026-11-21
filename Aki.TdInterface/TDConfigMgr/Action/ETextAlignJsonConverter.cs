using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200270D RID: 9997
	public class ETextAlignJsonConverter : JsonConverter<ETextAlign>
	{
		// Token: 0x0600D716 RID: 55062 RVA: 0x001F6BC8 File Offset: 0x001F4DC8
		public override ETextAlign Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETextAlign.Top;
			}
			return ETextAlignExtensions.FromString(@string);
		}

		// Token: 0x0600D717 RID: 55063 RVA: 0x001F6BEC File Offset: 0x001F4DEC
		public override void Write(Utf8JsonWriter writer, ETextAlign value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
