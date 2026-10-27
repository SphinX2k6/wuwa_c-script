using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B2 RID: 9394
	public class EVisualNovelPerformanceTypeJsonConverter : JsonConverter<EVisualNovelPerformanceType>
	{
		// Token: 0x0600CBA1 RID: 52129 RVA: 0x001DFC90 File Offset: 0x001DDE90
		public override EVisualNovelPerformanceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelPerformanceType.Enter;
			}
			return EVisualNovelPerformanceTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CBA2 RID: 52130 RVA: 0x001DFCB4 File Offset: 0x001DDEB4
		public override void Write(Utf8JsonWriter writer, EVisualNovelPerformanceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
