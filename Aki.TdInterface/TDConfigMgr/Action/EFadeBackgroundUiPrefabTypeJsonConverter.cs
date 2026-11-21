using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A9 RID: 9641
	public class EFadeBackgroundUiPrefabTypeJsonConverter : JsonConverter<EFadeBackgroundUiPrefabType>
	{
		// Token: 0x0600D0D4 RID: 53460 RVA: 0x001E4270 File Offset: 0x001E2470
		public override EFadeBackgroundUiPrefabType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
			}
			return EFadeBackgroundUiPrefabTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0D5 RID: 53461 RVA: 0x001E4294 File Offset: 0x001E2494
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundUiPrefabType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
