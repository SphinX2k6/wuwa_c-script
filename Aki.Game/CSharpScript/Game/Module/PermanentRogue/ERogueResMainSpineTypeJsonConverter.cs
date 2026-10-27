using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200534C RID: 21324
	public class ERogueResMainSpineTypeJsonConverter : JsonConverter<ERogueResMainSpineType>
	{
		// Token: 0x060367A3 RID: 223139 RVA: 0x00CE69B8 File Offset: 0x00CE4BB8
		public override ERogueResMainSpineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueResMainSpineType.Female;
			}
			return ERogueResMainSpineTypeExtensions.FromString(@string);
		}

		// Token: 0x060367A4 RID: 223140 RVA: 0x00CE69DC File Offset: 0x00CE4BDC
		public override void Write(Utf8JsonWriter writer, ERogueResMainSpineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
