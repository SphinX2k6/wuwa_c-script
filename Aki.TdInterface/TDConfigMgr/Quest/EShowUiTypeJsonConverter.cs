using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200128D RID: 4749
	public class EShowUiTypeJsonConverter : JsonConverter<EShowUiType>
	{
		// Token: 0x06006B23 RID: 27427 RVA: 0x001012DC File Offset: 0x000FF4DC
		public override EShowUiType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EShowUiType.All;
			}
			return EShowUiTypeExtensions.FromString(@string);
		}

		// Token: 0x06006B24 RID: 27428 RVA: 0x00101300 File Offset: 0x000FF500
		public override void Write(Utf8JsonWriter writer, EShowUiType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
