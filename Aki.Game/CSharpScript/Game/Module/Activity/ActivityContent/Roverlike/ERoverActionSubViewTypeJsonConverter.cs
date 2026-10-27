using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x020061AB RID: 25003
	public class ERoverActionSubViewTypeJsonConverter : JsonConverter<ERoverActionSubViewType>
	{
		// Token: 0x0603F259 RID: 258649 RVA: 0x00F41404 File Offset: 0x00F3F604
		public override ERoverActionSubViewType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoverActionSubViewType.None;
			}
			return ERoverActionSubViewTypeExtensions.FromString(@string);
		}

		// Token: 0x0603F25A RID: 258650 RVA: 0x00F41428 File Offset: 0x00F3F628
		public override void Write(Utf8JsonWriter writer, ERoverActionSubViewType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
