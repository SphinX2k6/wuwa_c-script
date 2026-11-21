using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A7E RID: 2686
	public class EPasserbyNpcSourceJsonConverter : JsonConverter<EPasserbyNpcSource>
	{
		// Token: 0x06003B4B RID: 15179 RVA: 0x00098DF4 File Offset: 0x00096FF4
		public override EPasserbyNpcSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcSource.Template;
			}
			return EPasserbyNpcSourceExtensions.FromString(@string);
		}

		// Token: 0x06003B4C RID: 15180 RVA: 0x00098E18 File Offset: 0x00097018
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcSource value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
