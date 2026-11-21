using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A66 RID: 2662
	public class ENoiseRemovalColorJsonConverter : JsonConverter<ENoiseRemovalColor>
	{
		// Token: 0x06003ADF RID: 15071 RVA: 0x00097F60 File Offset: 0x00096160
		public override ENoiseRemovalColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ENoiseRemovalColor.Red;
			}
			return ENoiseRemovalColorExtensions.FromString(@string);
		}

		// Token: 0x06003AE0 RID: 15072 RVA: 0x00097F84 File Offset: 0x00096184
		public override void Write(Utf8JsonWriter writer, ENoiseRemovalColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
