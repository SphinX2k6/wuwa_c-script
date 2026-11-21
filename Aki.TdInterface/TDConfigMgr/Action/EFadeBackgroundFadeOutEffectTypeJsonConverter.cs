using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025A5 RID: 9637
	public class EFadeBackgroundFadeOutEffectTypeJsonConverter : JsonConverter<EFadeBackgroundFadeOutEffectType>
	{
		// Token: 0x0600D0C2 RID: 53442 RVA: 0x001E403C File Offset: 0x001E223C
		public override EFadeBackgroundFadeOutEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundFadeOutEffectType.Black;
			}
			return EFadeBackgroundFadeOutEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D0C3 RID: 53443 RVA: 0x001E4060 File Offset: 0x001E2260
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundFadeOutEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
