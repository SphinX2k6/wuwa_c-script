using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A1 RID: 4769
	public class ETetrisDirectionJsonConverter : JsonConverter<ETetrisDirection>
	{
		// Token: 0x06006B7D RID: 27517 RVA: 0x001023E4 File Offset: 0x001005E4
		public override ETetrisDirection Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisDirection.UpDown;
			}
			return ETetrisDirectionExtensions.FromString(@string);
		}

		// Token: 0x06006B7E RID: 27518 RVA: 0x00102408 File Offset: 0x00100608
		public override void Write(Utf8JsonWriter writer, ETetrisDirection value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
