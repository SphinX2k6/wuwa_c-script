using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002753 RID: 10067
	public class EVisualNovelOptionInteractionTypeJsonConverter : JsonConverter<EVisualNovelOptionInteractionType>
	{
		// Token: 0x0600D851 RID: 55377 RVA: 0x001F9904 File Offset: 0x001F7B04
		public override EVisualNovelOptionInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelOptionInteractionType.HideAndAutoSelect;
			}
			return EVisualNovelOptionInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D852 RID: 55378 RVA: 0x001F9928 File Offset: 0x001F7B28
		public override void Write(Utf8JsonWriter writer, EVisualNovelOptionInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
