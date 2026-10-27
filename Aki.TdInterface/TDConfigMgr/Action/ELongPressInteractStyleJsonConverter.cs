using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002378 RID: 9080
	public class ELongPressInteractStyleJsonConverter : JsonConverter<ELongPressInteractStyle>
	{
		// Token: 0x0600C61C RID: 50716 RVA: 0x001D0620 File Offset: 0x001CE820
		public override ELongPressInteractStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ELongPressInteractStyle.Default;
			}
			return ELongPressInteractStyleExtensions.FromString(@string);
		}

		// Token: 0x0600C61D RID: 50717 RVA: 0x001D0644 File Offset: 0x001CE844
		public override void Write(Utf8JsonWriter writer, ELongPressInteractStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
