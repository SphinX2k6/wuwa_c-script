using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005621 RID: 22049
	public class EDropCatchCommandNameJsonConverter : JsonConverter<EDropCatchCommandName>
	{
		// Token: 0x0603684D RID: 223309 RVA: 0x00F37A60 File Offset: 0x00F35C60
		public override EDropCatchCommandName Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchCommandName.SpawnDropItem;
			}
			return EDropCatchCommandNameExtensions.FromString(@string);
		}

		// Token: 0x0603684E RID: 223310 RVA: 0x00F37A84 File Offset: 0x00F35C84
		public override void Write(Utf8JsonWriter writer, EDropCatchCommandName value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
