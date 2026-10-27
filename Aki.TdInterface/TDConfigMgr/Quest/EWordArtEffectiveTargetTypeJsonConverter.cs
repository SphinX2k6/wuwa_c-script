using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BD RID: 4797
	public class EWordArtEffectiveTargetTypeJsonConverter : JsonConverter<EWordArtEffectiveTargetType>
	{
		// Token: 0x06006BFB RID: 27643 RVA: 0x00103E08 File Offset: 0x00102008
		public override EWordArtEffectiveTargetType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWordArtEffectiveTargetType.Number;
			}
			return EWordArtEffectiveTargetTypeExtensions.FromString(@string);
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x00103E2C File Offset: 0x0010202C
		public override void Write(Utf8JsonWriter writer, EWordArtEffectiveTargetType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
