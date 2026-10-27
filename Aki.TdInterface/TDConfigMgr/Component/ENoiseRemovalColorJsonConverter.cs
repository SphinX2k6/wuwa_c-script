using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B1 RID: 2481
	public class ENoiseRemovalColorJsonConverter : JsonConverter<ENoiseRemovalColor>
	{
		// Token: 0x0600374F RID: 14159 RVA: 0x0008FE6C File Offset: 0x0008E06C
		public override ENoiseRemovalColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENoiseRemovalColor.Red;
			}
			return ENoiseRemovalColorExtensions.FromString(@string);
		}

		// Token: 0x06003750 RID: 14160 RVA: 0x0008FE90 File Offset: 0x0008E090
		public override void Write(Utf8JsonWriter writer, ENoiseRemovalColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
