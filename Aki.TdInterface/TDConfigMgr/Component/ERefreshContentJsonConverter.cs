using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AB4 RID: 2740
	public class ERefreshContentJsonConverter : JsonConverter<ERefreshContent>
	{
		// Token: 0x06003C3E RID: 15422 RVA: 0x0009A9A8 File Offset: 0x00098BA8
		public override ERefreshContent Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERefreshContent.All;
			}
			return ERefreshContentExtensions.FromString(@string);
		}

		// Token: 0x06003C3F RID: 15423 RVA: 0x0009A9CC File Offset: 0x00098BCC
		public override void Write(Utf8JsonWriter writer, ERefreshContent value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
