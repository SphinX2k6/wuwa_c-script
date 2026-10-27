using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D5 RID: 26325
	public class EDropCatchCommandSourceJsonConverter : JsonConverter<EDropCatchCommandSource>
	{
		// Token: 0x06041D13 RID: 269587 RVA: 0x00FF6890 File Offset: 0x00FF4A90
		public override EDropCatchCommandSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchCommandSource.Skill;
			}
			return EDropCatchCommandSourceExtensions.FromString(@string);
		}

		// Token: 0x06041D14 RID: 269588 RVA: 0x00FF68B4 File Offset: 0x00FF4AB4
		public override void Write(Utf8JsonWriter writer, EDropCatchCommandSource value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
