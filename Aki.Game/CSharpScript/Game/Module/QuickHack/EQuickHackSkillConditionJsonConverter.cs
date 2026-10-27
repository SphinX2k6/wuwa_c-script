using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CSharpScript.Game.Module.QuickHack
{
	// Token: 0x02004F8D RID: 20365
	public class EQuickHackSkillConditionJsonConverter : JsonConverter<EQuickHackSkillCondition>
	{
		// Token: 0x06034264 RID: 213604 RVA: 0x00C3D394 File Offset: 0x00C3B594
		public override EQuickHackSkillCondition Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			if (string.IsNullOrEmpty(@string))
			{
				return EQuickHackSkillCondition.CheckTargetTypeMatch;
			}
			return EQuickHackSkillConditionExtensions.FromString(@string);
		}

		// Token: 0x06034265 RID: 213605 RVA: 0x00C3D3B8 File Offset: 0x00C3B5B8
		public override void Write(Utf8JsonWriter writer, EQuickHackSkillCondition value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value.ToEnumString());
		}
	}
}
