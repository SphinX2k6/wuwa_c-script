using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AC RID: 9388
	public class EVisualNovelLayoutJsonConverter : JsonConverter<EVisualNovelLayout>
	{
		// Token: 0x0600CB86 RID: 52102 RVA: 0x001DF54C File Offset: 0x001DD74C
		public override EVisualNovelLayout Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelLayout.Portrait;
			}
			return EVisualNovelLayoutExtensions.FromString(@string);
		}

		// Token: 0x0600CB87 RID: 52103 RVA: 0x001DF570 File Offset: 0x001DD770
		public override void Write(Utf8JsonWriter writer, EVisualNovelLayout value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
