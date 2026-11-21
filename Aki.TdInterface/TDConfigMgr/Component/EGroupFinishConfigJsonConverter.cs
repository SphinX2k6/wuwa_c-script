using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A12 RID: 2578
	public class EGroupFinishConfigJsonConverter : JsonConverter<EGroupFinishConfig>
	{
		// Token: 0x06003965 RID: 14693 RVA: 0x00094458 File Offset: 0x00092658
		public override EGroupFinishConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupFinishConfig.Silence;
			}
			return EGroupFinishConfigExtensions.FromString(@string);
		}

		// Token: 0x06003966 RID: 14694 RVA: 0x0009447C File Offset: 0x0009267C
		public override void Write(Utf8JsonWriter writer, EGroupFinishConfig value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
