using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005625 RID: 22053
	public class EDropCatchCommandSourceJsonConverter : JsonConverter<EDropCatchCommandSource>
	{
		// Token: 0x0603685F RID: 223327 RVA: 0x00F37C94 File Offset: 0x00F35E94
		public override EDropCatchCommandSource Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchCommandSource.Skill;
			}
			return EDropCatchCommandSourceExtensions.FromString(@string);
		}

		// Token: 0x06036860 RID: 223328 RVA: 0x00F37CB8 File Offset: 0x00F35EB8
		public override void Write(Utf8JsonWriter writer, EDropCatchCommandSource value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
