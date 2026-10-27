using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.PreWarm
{
	// Token: 0x020062C3 RID: 25283
	public class EActivityPreWarmHexColorJsonConverter : JsonConverter<EActivityPreWarmHexColor>
	{
		// Token: 0x0603F95D RID: 260445 RVA: 0x00F6190C File Offset: 0x00F5FB0C
		public override EActivityPreWarmHexColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EActivityPreWarmHexColor.Red;
			}
			return EActivityPreWarmHexColorExtensions.FromString(@string);
		}

		// Token: 0x0603F95E RID: 260446 RVA: 0x00F61930 File Offset: 0x00F5FB30
		public override void Write(Utf8JsonWriter writer, EActivityPreWarmHexColor value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
