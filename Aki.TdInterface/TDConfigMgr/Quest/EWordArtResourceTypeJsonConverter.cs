using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012BF RID: 4799
	public class EWordArtResourceTypeJsonConverter : JsonConverter<EWordArtResourceType>
	{
		// Token: 0x06006C04 RID: 27652 RVA: 0x00103EE4 File Offset: 0x001020E4
		public override EWordArtResourceType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EWordArtResourceType.Default;
			}
			return EWordArtResourceTypeExtensions.FromString(@string);
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x00103F08 File Offset: 0x00102108
		public override void Write(Utf8JsonWriter writer, EWordArtResourceType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
