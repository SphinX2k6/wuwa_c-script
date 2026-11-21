using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000AF5 RID: 2805
	public static class ETeleControlLockingPerformExtensions
	{
		// Token: 0x06003D61 RID: 15713 RVA: 0x0009D254 File Offset: 0x0009B454
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

		// Token: 0x06003D62 RID: 15714 RVA: 0x0009D28C File Offset: 0x0009B48C
		public static ETeleControlLockingPerform FromString(string name)
		{
			ETeleControlLockingPerform result;
			if (!ETeleControlLockingPerformExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETeleControlLockingPerform 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x0009D2B5 File Offset: 0x0009B4B5
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

		// Token: 0x06003D64 RID: 15716 RVA: 0x0009D2EE File Offset: 0x0009B4EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"关卡.Common.表现.被控物.匹配正确",
				"关卡.Common.表现.被控物.匹配错误"
			};
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x0009D306 File Offset: 0x0009B506
		public static ETeleControlLockingPerform[] GetValues()
		{
			return new ETeleControlLockingPerform[]
			{
				ETeleControlLockingPerform.RightMatch,
				ETeleControlLockingPerform.WrongMatch
			};
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x0009D312 File Offset: 0x0009B512
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
