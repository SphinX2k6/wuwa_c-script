using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024AA RID: 9386
	public class EVisualNovelDisplayItemTypeJsonConverter : JsonConverter<EVisualNovelDisplayItemType>
	{
		// Token: 0x0600CB7D RID: 52093 RVA: 0x001DF438 File Offset: 0x001DD638
		public override EVisualNovelDisplayItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelDisplayItemType.Image;
			}
			return EVisualNovelDisplayItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB7E RID: 52094 RVA: 0x001DF45C File Offset: 0x001DD65C
		public override void Write(Utf8JsonWriter writer, EVisualNovelDisplayItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
