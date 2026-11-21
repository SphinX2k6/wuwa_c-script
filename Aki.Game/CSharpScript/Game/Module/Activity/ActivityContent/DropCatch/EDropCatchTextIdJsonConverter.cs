using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x02005617 RID: 22039
	public class EDropCatchTextIdJsonConverter : JsonConverter<EDropCatchTextId>
	{
		// Token: 0x06036820 RID: 223264 RVA: 0x00F36D00 File Offset: 0x00F34F00
		public override EDropCatchTextId Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchTextId.TextScoreLevel;
			}
			return EDropCatchTextIdExtensions.FromString(@string);
		}

		// Token: 0x06036821 RID: 223265 RVA: 0x00F36D24 File Offset: 0x00F34F24
		public override void Write(Utf8JsonWriter writer, EDropCatchTextId value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
