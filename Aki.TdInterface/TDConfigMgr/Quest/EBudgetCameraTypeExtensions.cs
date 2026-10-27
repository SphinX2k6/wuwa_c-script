using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122C RID: 4652
	public static class EBudgetCameraTypeExtensions
	{
		// Token: 0x0600696D RID: 26989 RVA: 0x000FB5A4 File Offset: 0x000F97A4
		public static string ToEnumString(this EBudgetCameraType value)
		{
			string result;
			if (value == EBudgetCameraType.Role)
			{
				result = "Role";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600696E RID: 26990 RVA: 0x000FB5CC File Offset: 0x000F97CC
		public static EBudgetCameraType FromString(string name)
		{
			EBudgetCameraType result;
			if (!EBudgetCameraTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBudgetCameraType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600696F RID: 26991 RVA: 0x000FB5F5 File Offset: 0x000F97F5
		public static bool TryFromString(string name, out EBudgetCameraType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBudgetCameraType.Role;
				return false;
			}
			if (name == "Role")
			{
				value = EBudgetCameraType.Role;
				return true;
			}
			value = EBudgetCameraType.Role;
			return false;
		}

		// Token: 0x06006970 RID: 26992 RVA: 0x000FB61A File Offset: 0x000F981A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Role"
			};
		}

		// Token: 0x06006971 RID: 26993 RVA: 0x000FB62A File Offset: 0x000F982A
		public static EBudgetCameraType[] GetValues()
		{
			return new EBudgetCameraType[1];
		}

		// Token: 0x06006972 RID: 26994 RVA: 0x000FB632 File Offset: 0x000F9832
		public static string[] GetNames()
		{
			return new string[]
			{
				"Role"
			};
		}
	}
}
