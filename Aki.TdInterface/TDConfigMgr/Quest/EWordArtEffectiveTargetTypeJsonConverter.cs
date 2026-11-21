using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001403 RID: 5123
	public class EWordArtEffectiveTargetTypeJsonConverter : JsonConverter<EWordArtEffectiveTargetType>
	{
		// Token: 0x06007269 RID: 29289 RVA: 0x00111DD0 File Offset: 0x0010FFD0
		public override EWordArtEffectiveTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWordArtEffectiveTargetType.Number;
			}
			return EWordArtEffectiveTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x0600726A RID: 29290 RVA: 0x00111DF4 File Offset: 0x0010FFF4
		public override void Write(Utf8JsonWriter writer, EWordArtEffectiveTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
