using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x020061FE RID: 25086
	public class ERoadBookAnimJsonConverter : JsonConverter<ERoadBookAnim>
	{
		// Token: 0x0603F4AF RID: 259247 RVA: 0x00F4B678 File Offset: 0x00F49878
		public override ERoadBookAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoadBookAnim.AniOpen;
			}
			return ERoadBookAnimExtensions.FromString(@string);
		}

		// Token: 0x0603F4B0 RID: 259248 RVA: 0x00F4B69C File Offset: 0x00F4989C
		public override void Write(Utf8JsonWriter writer, ERoadBookAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
