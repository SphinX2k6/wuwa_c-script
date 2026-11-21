using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200274D RID: 10061
	public class EVisualNovelDisplayItemTypeJsonConverter : JsonConverter<EVisualNovelDisplayItemType>
	{
		// Token: 0x0600D836 RID: 55350 RVA: 0x001F9600 File Offset: 0x001F7800
		public override EVisualNovelDisplayItemType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelDisplayItemType.Image;
			}
			return EVisualNovelDisplayItemTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D837 RID: 55351 RVA: 0x001F9624 File Offset: 0x001F7824
		public override void Write(Utf8JsonWriter writer, EVisualNovelDisplayItemType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
