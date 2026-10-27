using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A30 RID: 2608
	public static class ETeleControlLockingPerformExtensions
	{
		// Token: 0x06003989 RID: 14729 RVA: 0x00094920 File Offset: 0x00092B20
		public static string ToEnumString(this ETeleControlLockingPerform value)
		{
			string result;
			if (value != ETeleControlLockingPerform.RightMatch)
			{
				if (value != ETeleControlLockingPerform.WrongMatch)
				{
					result = value.ToString();
				}
				else
				{
					result = "关卡.Common.表现.被控物.匹配错误";
				}
			}
			else
			{
				result = "关卡.Common.表现.被控物.匹配正确";
			}
			return result;
		}

		// Token: 0x0600398A RID: 14730 RVA: 0x00094958 File Offset: 0x00092B58
		public static ETeleControlLockingPerform FromString(string name)
		{
			ETeleControlLockingPerform result;
			if (!ETeleControlLockingPerformExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleControlLockingPerform 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600398B RID: 14731 RVA: 0x00094981 File Offset: 0x00092B81
		public static bool TryFromString(string name, out ETeleControlLockingPerform value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETeleControlLockingPerform.RightMatch;
				return false;
			}
			if (name == "关卡.Common.表现.被控物.匹配正确")
			{
				value = ETeleControlLockingPerform.RightMatch;
				return true;
			}
			if (!(name == "关卡.Common.表现.被控物.匹配错误"))
			{
				value = ETeleControlLockingPerform.RightMatch;
				return false;
			}
			value = ETeleControlLockingPerform.WrongMatch;
			return true;
		}

		// Token: 0x0600398C RID: 14732 RVA: 0x000949BA File Offset: 0x00092BBA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"关卡.Common.表现.被控物.匹配正确",
				"关卡.Common.表现.被控物.匹配错误"
			};
		}

		// Token: 0x0600398D RID: 14733 RVA: 0x000949D2 File Offset: 0x00092BD2
		public static ETeleControlLockingPerform[] GetValues()
		{
			return new ETeleControlLockingPerform[]
			{
				ETeleControlLockingPerform.RightMatch,
				ETeleControlLockingPerform.WrongMatch
			};
		}

		// Token: 0x0600398E RID: 14734 RVA: 0x000949DE File Offset: 0x00092BDE
		public static string[] GetNames()
		{
			return new string[]
			{
				"RightMatch",
				"WrongMatch"
			};
		}
	}
}
