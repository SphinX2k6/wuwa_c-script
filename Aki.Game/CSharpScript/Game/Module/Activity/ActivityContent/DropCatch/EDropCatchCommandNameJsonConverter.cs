using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066D1 RID: 26321
	public class EDropCatchCommandNameJsonConverter : JsonConverter<EDropCatchCommandName>
	{
		// Token: 0x06041D01 RID: 269569 RVA: 0x00FF665C File Offset: 0x00FF485C
		public override EDropCatchCommandName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchCommandName.SpawnDropItem;
			}
			return EDropCatchCommandNameExtensions.FromString(@string);
		}

		// Token: 0x06041D02 RID: 269570 RVA: 0x00FF6680 File Offset: 0x00FF4880
		public override void Write(Utf8JsonWriter writer, EDropCatchCommandName value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
