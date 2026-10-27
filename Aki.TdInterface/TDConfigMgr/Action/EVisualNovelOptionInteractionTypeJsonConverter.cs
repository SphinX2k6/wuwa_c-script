using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B0 RID: 9392
	public class EVisualNovelOptionInteractionTypeJsonConverter : JsonConverter<EVisualNovelOptionInteractionType>
	{
		// Token: 0x0600CB98 RID: 52120 RVA: 0x001DF704 File Offset: 0x001DD904
		public override EVisualNovelOptionInteractionType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EVisualNovelOptionInteractionType.HideAndAutoSelect;
			}
			return EVisualNovelOptionInteractionTypeExtensions.FromString(@string);
		}

		// Token: 0x0600CB99 RID: 52121 RVA: 0x001DF728 File Offset: 0x001DD928
		public override void Write(Utf8JsonWriter writer, EVisualNovelOptionInteractionType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
