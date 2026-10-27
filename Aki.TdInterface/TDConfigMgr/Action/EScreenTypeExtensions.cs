using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023FF RID: 9215
	public static class EScreenTypeExtensions
	{
		// Token: 0x0600C87A RID: 51322 RVA: 0x001D5708 File Offset: 0x001D3908
		public static string ToEnumString(this EScreenType value)
		{
			string result;
			if (value != EScreenType.Main)
			{
				if (value != EScreenType.Sub)
				{
					result = value.ToString();
				}
				else
				{
					result = "Sub";
				}
			}
			else
			{
				result = "Main";
			}
			return result;
		}

		// Token: 0x0600C87B RID: 51323 RVA: 0x001D5740 File Offset: 0x001D3940
		public static EScreenType FromString(string name)
		{
			EScreenType result;
			if (!EScreenTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EScreenType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C87C RID: 51324 RVA: 0x001D5769 File Offset: 0x001D3969
		public static bool TryFromString(string name, out EScreenType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EScreenType.Main;
				return false;
			}
			if (name == "Main")
			{
				value = EScreenType.Main;
				return true;
			}
			if (!(name == "Sub"))
			{
				value = EScreenType.Main;
				return false;
			}
			value = EScreenType.Sub;
			return true;
		}

		// Token: 0x0600C87D RID: 51325 RVA: 0x001D57A2 File Offset: 0x001D39A2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Main",
				"Sub"
			};
		}

		// Token: 0x0600C87E RID: 51326 RVA: 0x001D57BA File Offset: 0x001D39BA
		public static EScreenType[] GetValues()
		{
			return new EScreenType[]
			{
				EScreenType.Main,
				EScreenType.Sub
			};
		}

		// Token: 0x0600C87F RID: 51327 RVA: 0x001D57C6 File Offset: 0x001D39C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"Main",
				"Sub"
			};
		}
	}
}
