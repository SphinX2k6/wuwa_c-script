using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009CF RID: 2511
	public class EPhantomExhibitSizeTypeJsonConverter : JsonConverter<EPhantomExhibitSizeType>
	{
		// Token: 0x060037D6 RID: 14294 RVA: 0x00091080 File Offset: 0x0008F280
		public override EPhantomExhibitSizeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhantomExhibitSizeType.Small;
			}
			return EPhantomExhibitSizeTypeExtensions.FromString(@string);
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x000910A4 File Offset: 0x0008F2A4
		public override void Write(Utf8JsonWriter writer, EPhantomExhibitSizeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
