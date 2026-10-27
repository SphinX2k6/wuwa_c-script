using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000903 RID: 2307
	public class EBossStateViewStyleJsonConverter : JsonConverter<EBossStateViewStyle>
	{
		// Token: 0x06003440 RID: 13376 RVA: 0x00085710 File Offset: 0x00083910
		public override EBossStateViewStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBossStateViewStyle.DoubleView;
			}
			return EBossStateViewStyleExtensions.FromString(@string);
		}

		// Token: 0x06003441 RID: 13377 RVA: 0x00085734 File Offset: 0x00083934
		public override void Write(Utf8JsonWriter writer, EBossStateViewStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
