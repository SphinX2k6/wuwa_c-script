using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002332 RID: 9010
	public class EFadeBackgroundFadeInEffectTypeJsonConverter : JsonConverter<EFadeBackgroundFadeInEffectType>
	{
		// Token: 0x0600C4E1 RID: 50401 RVA: 0x001CBE70 File Offset: 0x001CA070
		public override EFadeBackgroundFadeInEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundFadeInEffectType.Black;
			}
			return EFadeBackgroundFadeInEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4E2 RID: 50402 RVA: 0x001CBE94 File Offset: 0x001CA094
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundFadeInEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
