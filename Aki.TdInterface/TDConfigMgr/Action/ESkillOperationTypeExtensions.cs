using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200241D RID: 9245
	public static class ESkillOperationTypeExtensions
	{
		// Token: 0x0600C901 RID: 51457 RVA: 0x001D6FF4 File Offset: 0x001D51F4
		public static string ToEnumString(this ESkillOperationType value)
		{
			string result;
			switch (value)
			{
			case ESkillOperationType.Enable:
				result = "Enable";
				break;
			case ESkillOperationType.Disable:
				result = "Disable";
				break;
			case ESkillOperationType.DisableSection:
				result = "DisableSection";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C902 RID: 51458 RVA: 0x001D703C File Offset: 0x001D523C
		public static ESkillOperationType FromString(string name)
		{
			ESkillOperationType result;
			if (!ESkillOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkillOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C903 RID: 51459 RVA: 0x001D7068 File Offset: 0x001D5268
		public static bool TryFromString(string name, out ESkillOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESkillOperationType.Enable;
				return false;
			}
			if (name == "Enable")
			{
				value = ESkillOperationType.Enable;
				return true;
			}
			if (name == "Disable")
			{
				value = ESkillOperationType.Disable;
				return true;
			}
			if (!(name == "DisableSection"))
			{
				value = ESkillOperationType.Enable;
				return false;
			}
			value = ESkillOperationType.DisableSection;
			return true;
		}

		// Token: 0x0600C904 RID: 51460 RVA: 0x001D70BE File Offset: 0x001D52BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable",
				"DisableSection"
			};
		}

		// Token: 0x0600C905 RID: 51461 RVA: 0x001D70DE File Offset: 0x001D52DE
		public static ESkillOperationType[] GetValues()
		{
			return new ESkillOperationType[]
			{
				ESkillOperationType.Enable,
				ESkillOperationType.Disable,
				ESkillOperationType.DisableSection
			};
		}

		// Token: 0x0600C906 RID: 51462 RVA: 0x001D70EE File Offset: 0x001D52EE
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enable",
				"Disable",
				"DisableSection"
			};
		}
	}
}
