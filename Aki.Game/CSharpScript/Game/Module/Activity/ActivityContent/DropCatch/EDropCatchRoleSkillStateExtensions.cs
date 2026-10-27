using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x020066CE RID: 26318
	public static class EDropCatchRoleSkillStateExtensions
	{
		// Token: 0x06041CF2 RID: 269554 RVA: 0x00FF5F4C File Offset: 0x00FF414C
		public static string ToEnumString(this EDropCatchRoleSkillState value)
		{
			string result;
			switch (value)
			{
			case EDropCatchRoleSkillState.Disable:
				result = "Disable";
				break;
			case EDropCatchRoleSkillState.Enable:
				result = "Enable";
				break;
			case EDropCatchRoleSkillState.InSkill:
				result = "InSkill";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06041CF3 RID: 269555 RVA: 0x00FF5F94 File Offset: 0x00FF4194
		public static EDropCatchRoleSkillState FromString(string name)
		{
			EDropCatchRoleSkillState result;
			if (!EDropCatchRoleSkillStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchRoleSkillState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06041CF4 RID: 269556 RVA: 0x00FF5FC0 File Offset: 0x00FF41C0
		public static bool TryFromString(string name, out EDropCatchRoleSkillState value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDropCatchRoleSkillState.Disable;
				return false;
			}
			if (name == "Disable")
			{
				value = EDropCatchRoleSkillState.Disable;
				return true;
			}
			if (name == "Enable")
			{
				value = EDropCatchRoleSkillState.Enable;
				return true;
			}
			if (!(name == "InSkill"))
			{
				value = EDropCatchRoleSkillState.Disable;
				return false;
			}
			value = EDropCatchRoleSkillState.InSkill;
			return true;
		}

		// Token: 0x06041CF5 RID: 269557 RVA: 0x00FF6016 File Offset: 0x00FF4216
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Disable",
				"Enable",
				"InSkill"
			};
		}

		// Token: 0x06041CF6 RID: 269558 RVA: 0x00FF6036 File Offset: 0x00FF4236
		public static EDropCatchRoleSkillState[] GetValues()
		{
			return new EDropCatchRoleSkillState[]
			{
				EDropCatchRoleSkillState.Disable,
				EDropCatchRoleSkillState.Enable,
				EDropCatchRoleSkillState.InSkill
			};
		}

		// Token: 0x06041CF7 RID: 269559 RVA: 0x00FF6046 File Offset: 0x00FF4246
		public static string[] GetNames()
		{
			return new string[]
			{
				"Disable",
				"Enable",
				"InSkill"
			};
		}
	}
}
