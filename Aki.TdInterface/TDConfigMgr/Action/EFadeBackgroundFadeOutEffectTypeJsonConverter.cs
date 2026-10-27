using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002334 RID: 9012
	public class EFadeBackgroundFadeOutEffectTypeJsonConverter : JsonConverter<EFadeBackgroundFadeOutEffectType>
	{
		// Token: 0x0600C4EA RID: 50410 RVA: 0x001CBF84 File Offset: 0x001CA184
		public override EFadeBackgroundFadeOutEffectType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EFadeBackgroundFadeOutEffectType.Black;
			}
			return EFadeBackgroundFadeOutEffectTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C4EB RID: 50411 RVA: 0x001CBFA8 File Offset: 0x001CA1A8
		public override void Write(Utf8JsonWriter writer, EFadeBackgroundFadeOutEffectType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
