using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x02005241 RID: 21057
	public class EActivityPreWarmHexColorJsonConverter : JsonConverter<EActivityPreWarmHexColor>
	{
		// Token: 0x0603461E RID: 214558 RVA: 0x00EA8868 File Offset: 0x00EA6A68
		public override EActivityPreWarmHexColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActivityPreWarmHexColor.Red;
			}
			return EActivityPreWarmHexColorExtensions.FromString(@string);
		}

		// Token: 0x0603461F RID: 214559 RVA: 0x00EA888C File Offset: 0x00EA6A8C
		public override void Write(Utf8JsonWriter writer, EActivityPreWarmHexColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
