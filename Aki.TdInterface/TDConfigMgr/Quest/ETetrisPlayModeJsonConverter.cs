using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013EB RID: 5099
	public class ETetrisPlayModeJsonConverter : JsonConverter<ETetrisPlayMode>
	{
		// Token: 0x060071FD RID: 29181 RVA: 0x00110D44 File Offset: 0x0010EF44
		public override ETetrisPlayMode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ETetrisPlayMode.Normal;
			}
			return ETetrisPlayModeExtensions.FromString(@string);
		}

		// Token: 0x060071FE RID: 29182 RVA: 0x00110D68 File Offset: 0x0010EF68
		public override void Write(Utf8JsonWriter writer, ETetrisPlayMode value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
