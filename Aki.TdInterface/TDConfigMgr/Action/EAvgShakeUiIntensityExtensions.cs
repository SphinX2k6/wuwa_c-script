using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200251E RID: 9502
	public static class EAvgShakeUiIntensityExtensions
	{
		// Token: 0x0600CE61 RID: 52833 RVA: 0x001DEC80 File Offset: 0x001DCE80
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

		// Token: 0x0600CE62 RID: 52834 RVA: 0x001DECB8 File Offset: 0x001DCEB8
		public static EAvgShakeUiIntensity FromString(string name)
		{
			EAvgShakeUiIntensity result;
			if (!EAvgShakeUiIntensityExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAvgShakeUiIntensity 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE63 RID: 52835 RVA: 0x001DECE1 File Offset: 0x001DCEE1
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

		// Token: 0x0600CE64 RID: 52836 RVA: 0x001DED1A File Offset: 0x001DCF1A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Weak",
				"Strong"
			};
		}

		// Token: 0x0600CE65 RID: 52837 RVA: 0x001DED32 File Offset: 0x001DCF32
		public static EAvgShakeUiIntensity[] GetValues()
		{
			return new EAvgShakeUiIntensity[]
			{
				EAvgShakeUiIntensity.Weak,
				EAvgShakeUiIntensity.Strong
			};
		}

		// Token: 0x0600CE66 RID: 52838 RVA: 0x001DED3E File Offset: 0x001DCF3E
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
