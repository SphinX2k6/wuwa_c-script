using System;

namespace CSharpScript.Game.Module.Activity.ActivityContent.DropCatch
{
	// Token: 0x0200561E RID: 22046
	public static class EDropCatchRoleSkillStateExtensions
	{
		// Token: 0x0603683E RID: 223294 RVA: 0x00F37350 File Offset: 0x00F35550
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

		// Token: 0x0603683F RID: 223295 RVA: 0x00F37398 File Offset: 0x00F35598
		public static EDropCatchRoleSkillState FromString(string name)
		{
			EDropCatchRoleSkillState result;
			if (!EDropCatchRoleSkillStateExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDropCatchRoleSkillState 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06036840 RID: 223296 RVA: 0x00F373C4 File Offset: 0x00F355C4
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

		// Token: 0x06036841 RID: 223297 RVA: 0x00F3741A File Offset: 0x00F3561A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Disable",
				"Enable",
				"InSkill"
			};
		}

		// Token: 0x06036842 RID: 223298 RVA: 0x00F3743A File Offset: 0x00F3563A
		public static EDropCatchRoleSkillState[] GetValues()
		{
			return new EDropCatchRoleSkillState[]
			{
				EDropCatchRoleSkillState.Disable,
				EDropCatchRoleSkillState.Enable,
				EDropCatchRoleSkillState.InSkill
			};
		}

		// Token: 0x06036843 RID: 223299 RVA: 0x00F3744A File Offset: 0x00F3564A
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
