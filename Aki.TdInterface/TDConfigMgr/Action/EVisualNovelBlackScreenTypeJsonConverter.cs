using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002749 RID: 10057
	public class EVisualNovelBlackScreenTypeJsonConverter : JsonConverter<EVisualNovelBlackScreenType>
	{
		// Token: 0x0600D824 RID: 55332 RVA: 0x001F9350 File Offset: 0x001F7550
		public override EVisualNovelBlackScreenType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelBlackScreenType.Black;
			}
			return EVisualNovelBlackScreenTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D825 RID: 55333 RVA: 0x001F9374 File Offset: 0x001F7574
		public override void Write(Utf8JsonWriter writer, EVisualNovelBlackScreenType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
