using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200274F RID: 10063
	public class EVisualNovelLayoutJsonConverter : JsonConverter<EVisualNovelLayout>
	{
		// Token: 0x0600D83F RID: 55359 RVA: 0x001F9714 File Offset: 0x001F7914
		public override EVisualNovelLayout Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelLayout.Portrait;
			}
			return EVisualNovelLayoutExtensions.FromString(@string);
		}

		// Token: 0x0600D840 RID: 55360 RVA: 0x001F9738 File Offset: 0x001F7938
		public override void Write(Utf8JsonWriter writer, EVisualNovelLayout value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
