using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002747 RID: 10055
	public class EVisualNovelBackgroundTypeJsonConverter : JsonConverter<EVisualNovelBackgroundType>
	{
		// Token: 0x0600D81B RID: 55323 RVA: 0x001F923C File Offset: 0x001F743C
		public override EVisualNovelBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelBackgroundType.Load;
			}
			return EVisualNovelBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D81C RID: 55324 RVA: 0x001F9260 File Offset: 0x001F7460
		public override void Write(Utf8JsonWriter writer, EVisualNovelBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
