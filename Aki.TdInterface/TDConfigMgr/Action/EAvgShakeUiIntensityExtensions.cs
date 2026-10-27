using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022AF RID: 8879
	public static class EAvgShakeUiIntensityExtensions
	{
		// Token: 0x0600C292 RID: 49810 RVA: 0x001C6E78 File Offset: 0x001C5078
		public static string ToEnumString(this EAvgShakeUiIntensity value)
		{
			string result;
			if (value != EAvgShakeUiIntensity.Weak)
			{
				if (value != EAvgShakeUiIntensity.Strong)
				{
					result = value.ToString();
				}
				else
				{
					result = "Strong";
				}
			}
			else
			{
				result = "Weak";
			}
			return result;
		}

		// Token: 0x0600C293 RID: 49811 RVA: 0x001C6EB0 File Offset: 0x001C50B0
		public static EAvgShakeUiIntensity FromString(string name)
		{
			EAvgShakeUiIntensity result;
			if (!EAvgShakeUiIntensityExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgShakeUiIntensity 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C294 RID: 49812 RVA: 0x001C6ED9 File Offset: 0x001C50D9
		public static bool TryFromString(string name, out EAvgShakeUiIntensity value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAvgShakeUiIntensity.Weak;
				return false;
			}
			if (name == "Weak")
			{
				value = EAvgShakeUiIntensity.Weak;
				return true;
			}
			if (!(name == "Strong"))
			{
				value = EAvgShakeUiIntensity.Weak;
				return false;
			}
			value = EAvgShakeUiIntensity.Strong;
			return true;
		}

		// Token: 0x0600C295 RID: 49813 RVA: 0x001C6F12 File Offset: 0x001C5112
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Weak",
				"Strong"
			};
		}

		// Token: 0x0600C296 RID: 49814 RVA: 0x001C6F2A File Offset: 0x001C512A
		public static EAvgShakeUiIntensity[] GetValues()
		{
			return new EAvgShakeUiIntensity[]
			{
				EAvgShakeUiIntensity.Weak,
				EAvgShakeUiIntensity.Strong
			};
		}

		// Token: 0x0600C297 RID: 49815 RVA: 0x001C6F36 File Offset: 0x001C5136
		public static string[] GetNames()
		{
			return new string[]
			{
				"Weak",
				"Strong"
			};
		}
	}
}
