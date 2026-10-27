using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200095F RID: 2399
	public class EGroupFinishConfigJsonConverter : JsonConverter<EGroupFinishConfig>
	{
		// Token: 0x060035DE RID: 13790 RVA: 0x0008C504 File Offset: 0x0008A704
		public override EGroupFinishConfig Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EGroupFinishConfig.Silence;
			}
			return EGroupFinishConfigExtensions.FromString(@string);
		}

		// Token: 0x060035DF RID: 13791 RVA: 0x0008C528 File Offset: 0x0008A728
		public override void Write(Utf8JsonWriter writer, EGroupFinishConfig value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
