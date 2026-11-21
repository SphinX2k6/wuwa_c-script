using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200258F RID: 9615
	public class EEnterMovieModeDurationTypeJsonConverter : JsonConverter<EEnterMovieModeDurationType>
	{
		// Token: 0x0600D05F RID: 53343 RVA: 0x001E2F68 File Offset: 0x001E1168
		public override EEnterMovieModeDurationType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EEnterMovieModeDurationType.BorderAnimFinished;
			}
			return EEnterMovieModeDurationTypeExtensions.FromString(@string);
		}

		// Token: 0x0600D060 RID: 53344 RVA: 0x001E2F8C File Offset: 0x001E118C
		public override void Write(Utf8JsonWriter writer, EEnterMovieModeDurationType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
