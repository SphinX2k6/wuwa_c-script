using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024A4 RID: 9380
	public class EVisualNovelBackgroundTypeJsonConverter : JsonConverter<EVisualNovelBackgroundType>
	{
		// Token: 0x0600CB62 RID: 52066 RVA: 0x001DF074 File Offset: 0x001DD274
		public override EVisualNovelBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelBackgroundType.Load;
			}
			return EVisualNovelBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB63 RID: 52067 RVA: 0x001DF098 File Offset: 0x001DD298
		public override void Write(Utf8JsonWriter writer, EVisualNovelBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
