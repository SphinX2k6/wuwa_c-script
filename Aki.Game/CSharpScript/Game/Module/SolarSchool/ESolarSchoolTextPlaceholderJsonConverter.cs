using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.SolarSchool
{
	// Token: 0x02005A7A RID: 23162
	public class ESolarSchoolTextPlaceholderJsonConverter : JsonConverter<ESolarSchoolTextPlaceholder>
	{
		// Token: 0x0603917D RID: 233853 RVA: 0x00FFDBF8 File Offset: 0x00FFBDF8
		public override ESolarSchoolTextPlaceholder Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ESolarSchoolTextPlaceholder.None;
			}
			return ESolarSchoolTextPlaceholderExtensions.FromString(@string);
		}

		// Token: 0x0603917E RID: 233854 RVA: 0x00FFDC1C File Offset: 0x00FFBE1C
		public override void Write(Utf8JsonWriter writer, ESolarSchoolTextPlaceholder value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
