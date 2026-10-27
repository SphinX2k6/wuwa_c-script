using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001229 RID: 4649
	public class EBindingProgressTypeJsonConverter : JsonConverter<EBindingProgressType>
	{
		// Token: 0x06006961 RID: 26977 RVA: 0x000FB0D0 File Offset: 0x000F92D0
		public override EBindingProgressType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EBindingProgressType.PlayerHavingItemCount;
			}
			return EBindingProgressTypeExtensions.FromString(@string);
		}

		// Token: 0x06006962 RID: 26978 RVA: 0x000FB0F4 File Offset: 0x000F92F4
		public override void Write(Utf8JsonWriter writer, EBindingProgressType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
