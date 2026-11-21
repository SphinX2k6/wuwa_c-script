using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001405 RID: 5125
	public class EWordArtResourceTypeJsonConverter : JsonConverter<EWordArtResourceType>
	{
		// Token: 0x06007272 RID: 29298 RVA: 0x00111EAC File Offset: 0x001100AC
		public override EWordArtResourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWordArtResourceType.Default;
			}
			return EWordArtResourceTypeExtensions.FromString(@string);
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x00111ED0 File Offset: 0x001100D0
		public override void Write(Utf8JsonWriter writer, EWordArtResourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
