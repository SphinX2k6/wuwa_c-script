using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066CF RID: 26319
	public class EDropCatchRoleSkillStateJsonConverter : JsonConverter<EDropCatchRoleSkillState>
	{
		// Token: 0x06041CF8 RID: 269560 RVA: 0x00FF6068 File Offset: 0x00FF4268
		public override EDropCatchRoleSkillState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchRoleSkillState.Disable;
			}
			return EDropCatchRoleSkillStateExtensions.FromString(@string);
		}

		// Token: 0x06041CF9 RID: 269561 RVA: 0x00FF608C File Offset: 0x00FF428C
		public override void Write(Utf8JsonWriter writer, EDropCatchRoleSkillState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
