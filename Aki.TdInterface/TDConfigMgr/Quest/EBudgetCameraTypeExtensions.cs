using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001368 RID: 4968
	public static class EBudgetCameraTypeExtensions
	{
		// Token: 0x06006FAE RID: 28590 RVA: 0x00108EB0 File Offset: 0x001070B0
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

		// Token: 0x06006FAF RID: 28591 RVA: 0x00108ED8 File Offset: 0x001070D8
		public static EBudgetCameraType FromString(string name)
		{
			EBudgetCameraType result;
			if (!EBudgetCameraTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBudgetCameraType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FB0 RID: 28592 RVA: 0x00108F01 File Offset: 0x00107101
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

		// Token: 0x06006FB1 RID: 28593 RVA: 0x00108F26 File Offset: 0x00107126
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Role"
			};
		}

		// Token: 0x06006FB2 RID: 28594 RVA: 0x00108F36 File Offset: 0x00107136
		public static EBudgetCameraType[] GetValues()
		{
			return new EBudgetCameraType[1];
		}

		// Token: 0x06006FB3 RID: 28595 RVA: 0x00108F3E File Offset: 0x0010713E
		public static string[] GetNames()
		{
			return new string[]
			{
				"Role"
			};
		}
	}
}
