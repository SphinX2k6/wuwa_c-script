using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200561F RID: 22047
	public class EDropCatchRoleSkillStateJsonConverter : JsonConverter<EDropCatchRoleSkillState>
	{
		// Token: 0x06036844 RID: 223300 RVA: 0x00F3746C File Offset: 0x00F3566C
		public override EDropCatchRoleSkillState Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EDropCatchRoleSkillState.Disable;
			}
			return EDropCatchRoleSkillStateExtensions.FromString(@string);
		}

		// Token: 0x06036845 RID: 223301 RVA: 0x00F37490 File Offset: 0x00F35690
		public override void Write(Utf8JsonWriter writer, EDropCatchRoleSkillState value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
