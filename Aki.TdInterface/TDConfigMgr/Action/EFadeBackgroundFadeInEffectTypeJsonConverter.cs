using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A3 RID: 9635
	public class EFadeBackgroundFadeInEffectTypeJsonConverter : JsonConverter<EFadeBackgroundFadeInEffectType>
	{
		// Token: 0x0600D0B9 RID: 53433 RVA: 0x001E3F28 File Offset: 0x001E2128
		public override EFadeBackgroundFadeInEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundFadeInEffectType.Black;
			}
			return EFadeBackgroundFadeInEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0BA RID: 53434 RVA: 0x001E3F4C File Offset: 0x001E214C
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundFadeInEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
