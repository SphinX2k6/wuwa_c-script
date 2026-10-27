using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002338 RID: 9016
	public class EFadeBackgroundUiPrefabTypeJsonConverter : JsonConverter<EFadeBackgroundUiPrefabType>
	{
		// Token: 0x0600C4FC RID: 50428 RVA: 0x001CC1B8 File Offset: 0x001CA3B8
		public override EFadeBackgroundUiPrefabType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundUiPrefabType.BlackScreenWhiteText;
			}
			return EFadeBackgroundUiPrefabTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4FD RID: 50429 RVA: 0x001CC1DC File Offset: 0x001CA3DC
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundUiPrefabType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
