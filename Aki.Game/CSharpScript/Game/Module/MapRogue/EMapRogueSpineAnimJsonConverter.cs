using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.MapRogue
{
	// Token: 0x02005641 RID: 22081
	public class EMapRogueSpineAnimJsonConverter : JsonConverter<EMapRogueSpineAnim>
	{
		// Token: 0x06038241 RID: 229953 RVA: 0x00D4C5DC File Offset: 0x00D4A7DC
		public override EMapRogueSpineAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMapRogueSpineAnim.Idle;
			}
			return EMapRogueSpineAnimExtensions.FromString(@string);
		}

		// Token: 0x06038242 RID: 229954 RVA: 0x00D4C600 File Offset: 0x00D4A800
		public override void Write(Utf8JsonWriter writer, EMapRogueSpineAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
