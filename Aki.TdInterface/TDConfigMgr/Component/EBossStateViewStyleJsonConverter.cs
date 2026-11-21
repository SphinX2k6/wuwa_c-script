using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009AC RID: 2476
	public class EBossStateViewStyleJsonConverter : JsonConverter<EBossStateViewStyle>
	{
		// Token: 0x0600379A RID: 14234 RVA: 0x0008CF80 File Offset: 0x0008B180
		public override EBossStateViewStyle Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBossStateViewStyle.DoubleView;
			}
			return EBossStateViewStyleExtensions.FromString(@string);
		}

		// Token: 0x0600379B RID: 14235 RVA: 0x0008CFA4 File Offset: 0x0008B1A4
		public override void Write(Utf8JsonWriter writer, EBossStateViewStyle value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
