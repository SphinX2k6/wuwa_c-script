using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022A9 RID: 8873
	public static class EAvgPlayRoleActionTypeExtensions
	{
		// Token: 0x0600C277 RID: 49783 RVA: 0x001C68F0 File Offset: 0x001C4AF0
		public static string ToEnumString(this EAvgPlayRoleActionType value)
		{
			string result;
			switch (value)
			{
			case EAvgPlayRoleActionType.Enter:
				result = "Enter";
				break;
			case EAvgPlayRoleActionType.GroupDialog:
				result = "GroupDialog";
				break;
			case EAvgPlayRoleActionType.Exit:
				result = "Exit";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C278 RID: 49784 RVA: 0x001C6938 File Offset: 0x001C4B38
		public static EAvgPlayRoleActionType FromString(string name)
		{
			EAvgPlayRoleActionType result;
			if (!EAvgPlayRoleActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgPlayRoleActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C279 RID: 49785 RVA: 0x001C6964 File Offset: 0x001C4B64
		public static bool TryFromString(string name, out EAvgPlayRoleActionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAvgPlayRoleActionType.Enter;
				return false;
			}
			if (name == "Enter")
			{
				value = EAvgPlayRoleActionType.Enter;
				return true;
			}
			if (name == "GroupDialog")
			{
				value = EAvgPlayRoleActionType.GroupDialog;
				return true;
			}
			if (!(name == "Exit"))
			{
				value = EAvgPlayRoleActionType.Enter;
				return false;
			}
			value = EAvgPlayRoleActionType.Exit;
			return true;
		}

		// Token: 0x0600C27A RID: 49786 RVA: 0x001C69BA File Offset: 0x001C4BBA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enter",
				"GroupDialog",
				"Exit"
			};
		}

		// Token: 0x0600C27B RID: 49787 RVA: 0x001C69DA File Offset: 0x001C4BDA
		public static EAvgPlayRoleActionType[] GetValues()
		{
			return new EAvgPlayRoleActionType[]
			{
				EAvgPlayRoleActionType.Enter,
				EAvgPlayRoleActionType.GroupDialog,
				EAvgPlayRoleActionType.Exit
			};
		}

		// Token: 0x0600C27C RID: 49788 RVA: 0x001C69EA File Offset: 0x001C4BEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Enter",
				"GroupDialog",
				"Exit"
			};
		}
	}
}
