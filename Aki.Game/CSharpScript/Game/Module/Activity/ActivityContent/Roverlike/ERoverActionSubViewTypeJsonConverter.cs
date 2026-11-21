using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.Roverlike
{
	// Token: 0x02005129 RID: 20777
	public class ERoverActionSubViewTypeJsonConverter : JsonConverter<ERoverActionSubViewType>
	{
		// Token: 0x06033F19 RID: 212761 RVA: 0x00E882CC File Offset: 0x00E864CC
		public override ERoverActionSubViewType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERoverActionSubViewType.None;
			}
			return ERoverActionSubViewTypeExtensions.FromString(@string);
		}

		// Token: 0x06033F1A RID: 212762 RVA: 0x00E882F0 File Offset: 0x00E864F0
		public override void Write(Utf8JsonWriter writer, ERoverActionSubViewType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
