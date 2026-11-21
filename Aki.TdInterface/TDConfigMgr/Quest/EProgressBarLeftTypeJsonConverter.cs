using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013AD RID: 5037
	public class EProgressBarLeftTypeJsonConverter : JsonConverter<EProgressBarLeftType>
	{
		// Token: 0x060070E6 RID: 28902 RVA: 0x0010D3F8 File Offset: 0x0010B5F8
		public override EProgressBarLeftType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EProgressBarLeftType.UseCount;
			}
			return EProgressBarLeftTypeExtensions.FromString(@string);
		}

		// Token: 0x060070E7 RID: 28903 RVA: 0x0010D41C File Offset: 0x0010B61C
		public override void Write(Utf8JsonWriter writer, EProgressBarLeftType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
