using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002490 RID: 9360
	public class EUiElementJsonConverter : JsonConverter<EUiElement>
	{
		// Token: 0x0600CB08 RID: 51976 RVA: 0x001DE474 File Offset: 0x001DC674
		public override EUiElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUiElement.Guide;
			}
			return EUiElementExtensions.FromString(@string);
		}

		// Token: 0x0600CB09 RID: 51977 RVA: 0x001DE498 File Offset: 0x001DC698
		public override void Write(Utf8JsonWriter writer, EUiElement value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
