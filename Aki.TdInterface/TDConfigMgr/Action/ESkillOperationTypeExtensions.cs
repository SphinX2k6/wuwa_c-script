using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026BC RID: 9916
	public static class ESkillOperationTypeExtensions
	{
		// Token: 0x0600D5A8 RID: 54696 RVA: 0x001F0CC8 File Offset: 0x001EEEC8
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

		// Token: 0x0600D5A9 RID: 54697 RVA: 0x001F0D10 File Offset: 0x001EEF10
		public static ESkillOperationType FromString(string name)
		{
			ESkillOperationType result;
			if (!ESkillOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESkillOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D5AA RID: 54698 RVA: 0x001F0D3C File Offset: 0x001EEF3C
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

		// Token: 0x0600D5AB RID: 54699 RVA: 0x001F0D92 File Offset: 0x001EEF92
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enable",
				"Disable",
				"DisableSection"
			};
		}

		// Token: 0x0600D5AC RID: 54700 RVA: 0x001F0DB2 File Offset: 0x001EEFB2
		public static ESkillOperationType[] GetValues()
		{
			return new ESkillOperationType[]
			{
				ESkillOperationType.Enable,
				ESkillOperationType.Disable,
				ESkillOperationType.DisableSection
			};
		}

		// Token: 0x0600D5AD RID: 54701 RVA: 0x001F0DC2 File Offset: 0x001EEFC2
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
