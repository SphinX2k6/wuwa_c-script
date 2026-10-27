using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009F6 RID: 2550
	public static class ERewardDropTypeExtensions
	{
		// Token: 0x06003884 RID: 14468 RVA: 0x000925E8 File Offset: 0x000907E8
		public static string ToEnumString(this ERewardDropType value)
		{
			string result;
			if (value != ERewardDropType.Death)
			{
				if (value != ERewardDropType.HostInteract)
				{
					result = value.ToString();
				}
				else
				{
					result = "HostInteract";
				}
			}
			else
			{
				result = "Death";
			}
			return result;
		}

		// Token: 0x06003885 RID: 14469 RVA: 0x00092620 File Offset: 0x00090820
		public static ERewardDropType FromString(string name)
		{
			ERewardDropType result;
			if (!ERewardDropTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERewardDropType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003886 RID: 14470 RVA: 0x00092649 File Offset: 0x00090849
		public static bool TryFromString(string name, out ERewardDropType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERewardDropType.Death;
				return false;
			}
			if (name == "Death")
			{
				value = ERewardDropType.Death;
				return true;
			}
			if (!(name == "HostInteract"))
			{
				value = ERewardDropType.Death;
				return false;
			}
			value = ERewardDropType.HostInteract;
			return true;
		}

		// Token: 0x06003887 RID: 14471 RVA: 0x00092682 File Offset: 0x00090882
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Death",
				"HostInteract"
			};
		}

		// Token: 0x06003888 RID: 14472 RVA: 0x0009269A File Offset: 0x0009089A
		public static ERewardDropType[] GetValues()
		{
			return new ERewardDropType[]
			{
				ERewardDropType.Death,
				ERewardDropType.HostInteract
			};
		}

		// Token: 0x06003889 RID: 14473 RVA: 0x000926A6 File Offset: 0x000908A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Death",
				"HostInteract"
			};
		}
	}
}
