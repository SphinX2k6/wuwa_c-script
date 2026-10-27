using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023A2 RID: 9122
	public class EMovieBackgroundTypeJsonConverter : JsonConverter<EMovieBackgroundType>
	{
		// Token: 0x0600C6D9 RID: 50905 RVA: 0x001D1E54 File Offset: 0x001D0054
		public override EMovieBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMovieBackgroundType.White;
			}
			return EMovieBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C6DA RID: 50906 RVA: 0x001D1E78 File Offset: 0x001D0078
		public override void Write(Utf8JsonWriter writer, EMovieBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
