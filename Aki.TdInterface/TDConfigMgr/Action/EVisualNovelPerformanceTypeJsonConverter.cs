using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002755 RID: 10069
	public class EVisualNovelPerformanceTypeJsonConverter : JsonConverter<EVisualNovelPerformanceType>
	{
		// Token: 0x0600D85A RID: 55386 RVA: 0x001F9E48 File Offset: 0x001F8048
		public override EVisualNovelPerformanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelPerformanceType.Enter;
			}
			return EVisualNovelPerformanceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D85B RID: 55387 RVA: 0x001F9E6C File Offset: 0x001F806C
		public override void Write(Utf8JsonWriter writer, EVisualNovelPerformanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
