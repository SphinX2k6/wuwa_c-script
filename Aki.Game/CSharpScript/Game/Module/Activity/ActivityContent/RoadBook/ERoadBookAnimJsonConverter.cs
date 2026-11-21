using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.RoadBook
{
	// Token: 0x0200517C RID: 20860
	public class ERoadBookAnimJsonConverter : JsonConverter<ERoadBookAnim>
	{
		// Token: 0x06034170 RID: 213360 RVA: 0x00E925D0 File Offset: 0x00E907D0
		public override ERoadBookAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoadBookAnim.AniOpen;
			}
			return ERoadBookAnimExtensions.FromString(@string);
		}

		// Token: 0x06034171 RID: 213361 RVA: 0x00E925F4 File Offset: 0x00E907F4
		public override void Write(Utf8JsonWriter writer, ERoadBookAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
