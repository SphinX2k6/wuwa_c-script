using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.MatchThree.Gameplay
{
	// Token: 0x020064D0 RID: 25808
	public class EMatchThreeRoleSpineAnimJsonConverter : JsonConverter<EMatchThreeRoleSpineAnim>
	{
		// Token: 0x06040C3D RID: 265277 RVA: 0x00FAEEDC File Offset: 0x00FAD0DC
		public override EMatchThreeRoleSpineAnim Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EMatchThreeRoleSpineAnim.Idle;
			}
			return EMatchThreeRoleSpineAnimExtensions.FromString(@string);
		}

		// Token: 0x06040C3E RID: 265278 RVA: 0x00FAEF00 File Offset: 0x00FAD100
		public override void Write(Utf8JsonWriter writer, EMatchThreeRoleSpineAnim value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
