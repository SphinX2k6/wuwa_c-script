using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002518 RID: 9496
	public static class EAvgPlayRoleActionTypeExtensions
	{
		// Token: 0x0600CE46 RID: 52806 RVA: 0x001DE6F8 File Offset: 0x001DC8F8
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

		// Token: 0x0600CE47 RID: 52807 RVA: 0x001DE740 File Offset: 0x001DC940
		public static EAvgPlayRoleActionType FromString(string name)
		{
			EAvgPlayRoleActionType result;
			if (!EAvgPlayRoleActionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgPlayRoleActionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE48 RID: 52808 RVA: 0x001DE76C File Offset: 0x001DC96C
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

		// Token: 0x0600CE49 RID: 52809 RVA: 0x001DE7C2 File Offset: 0x001DC9C2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Enter",
				"GroupDialog",
				"Exit"
			};
		}

		// Token: 0x0600CE4A RID: 52810 RVA: 0x001DE7E2 File Offset: 0x001DC9E2
		public static EAvgPlayRoleActionType[] GetValues()
		{
			return new EAvgPlayRoleActionType[]
			{
				EAvgPlayRoleActionType.Enter,
				EAvgPlayRoleActionType.GroupDialog,
				EAvgPlayRoleActionType.Exit
			};
		}

		// Token: 0x0600CE4B RID: 52811 RVA: 0x001DE7F2 File Offset: 0x001DC9F2
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
