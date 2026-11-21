using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.PermanentRogue
{
	// Token: 0x0200431C RID: 17180
	public class ERogueResMainSpineTypeJsonConverter : JsonConverter<ERogueResMainSpineType>
	{
		// Token: 0x0602B69F RID: 177823 RVA: 0x00C34388 File Offset: 0x00C32588
		public override ERogueResMainSpineType Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return ERogueResMainSpineType.Female;
			}
			return ERogueResMainSpineTypeExtensions.FromString(@string);
		}

		// Token: 0x0602B6A0 RID: 177824 RVA: 0x00C343AC File Offset: 0x00C325AC
		public override void Write(Utf8JsonWriter writer, ERogueResMainSpineType value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
