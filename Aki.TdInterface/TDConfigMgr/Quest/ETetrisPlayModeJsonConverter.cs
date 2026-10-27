using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012A5 RID: 4773
	public class ETetrisPlayModeJsonConverter : JsonConverter<ETetrisPlayMode>
	{
		// Token: 0x06006B8F RID: 27535 RVA: 0x00102D7C File Offset: 0x00100F7C
		public override ETetrisPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisPlayMode.Normal;
			}
			return ETetrisPlayModeExtensions.FromString(@string);
		}

		// Token: 0x06006B90 RID: 27536 RVA: 0x00102DA0 File Offset: 0x00100FA0
		public override void Write(Utf8JsonWriter writer, ETetrisPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
