using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x0200544E RID: 21582
	public class EMatchThreeRoleSpineAnimJsonConverter : JsonConverter<EMatchThreeRoleSpineAnim>
	{
		// Token: 0x06035901 RID: 219393 RVA: 0x00EF5F24 File Offset: 0x00EF4124
		public override EMatchThreeRoleSpineAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeRoleSpineAnim.Idle;
			}
			return EMatchThreeRoleSpineAnimExtensions.FromString(@string);
		}

		// Token: 0x06035902 RID: 219394 RVA: 0x00EF5F48 File Offset: 0x00EF4148
		public override void Write(Utf8JsonWriter writer, EMatchThreeRoleSpineAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
