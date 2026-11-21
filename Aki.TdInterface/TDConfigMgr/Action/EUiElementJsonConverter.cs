using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002733 RID: 10035
	public class EUiElementJsonConverter : JsonConverter<EUiElement>
	{
		// Token: 0x0600D7C1 RID: 55233 RVA: 0x001F863C File Offset: 0x001F683C
		public override EUiElement Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EUiElement.Guide;
			}
			return EUiElementExtensions.FromString(@string);
		}

		// Token: 0x0600D7C2 RID: 55234 RVA: 0x001F8660 File Offset: 0x001F6860
		public override void Write(Utf8JsonWriter writer, EUiElement value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
