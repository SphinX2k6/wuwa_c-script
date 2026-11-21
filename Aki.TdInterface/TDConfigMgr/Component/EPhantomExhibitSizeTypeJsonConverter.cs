using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A94 RID: 2708
	public class EPhantomExhibitSizeTypeJsonConverter : JsonConverter<EPhantomExhibitSizeType>
	{
		// Token: 0x06003BAE RID: 15278 RVA: 0x00099940 File Offset: 0x00097B40
		public override EPhantomExhibitSizeType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EPhantomExhibitSizeType.Small;
			}
			return EPhantomExhibitSizeTypeExtensions.FromString(@string);
		}

		// Token: 0x06003BAF RID: 15279 RVA: 0x00099964 File Offset: 0x00097B64
		public override void Write(Utf8JsonWriter writer, EPhantomExhibitSizeType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
