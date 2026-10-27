using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002320 RID: 8992
	public class EEnterMovieModeDurationTypeJsonConverter : JsonConverter<EEnterMovieModeDurationType>
	{
		// Token: 0x0600C490 RID: 50320 RVA: 0x001CB0A0 File Offset: 0x001C92A0
		public override EEnterMovieModeDurationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnterMovieModeDurationType.BorderAnimFinished;
			}
			return EEnterMovieModeDurationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600C491 RID: 50321 RVA: 0x001CB0C4 File Offset: 0x001C92C4
		public override void Write(Utf8JsonWriter writer, EEnterMovieModeDurationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
