using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200262D RID: 9773
	public class EMovieBackgroundTypeJsonConverter : JsonConverter<EMovieBackgroundType>
	{
		// Token: 0x0600D326 RID: 54054 RVA: 0x001EAFF4 File Offset: 0x001E91F4
		public override EMovieBackgroundType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMovieBackgroundType.White;
			}
			return EMovieBackgroundTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D327 RID: 54055 RVA: 0x001EB018 File Offset: 0x001E9218
		public override void Write(Utf8JsonWriter writer, EMovieBackgroundType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
