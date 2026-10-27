using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009BF RID: 2495
	public class EPasserbyNpcSourceJsonConverter : JsonConverter<EPasserbyNpcSource>
	{
		// Token: 0x0600378E RID: 14222 RVA: 0x00090838 File Offset: 0x0008EA38
		public override EPasserbyNpcSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPasserbyNpcSource.Template;
			}
			return EPasserbyNpcSourceExtensions.FromString(@string);
		}

		// Token: 0x0600378F RID: 14223 RVA: 0x0009085C File Offset: 0x0008EA5C
		public override void Write(Utf8JsonWriter writer, EPasserbyNpcSource value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
