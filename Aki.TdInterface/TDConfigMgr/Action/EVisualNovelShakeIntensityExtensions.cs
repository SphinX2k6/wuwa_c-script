using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B5 RID: 9397
	public static class EVisualNovelShakeIntensityExtensions
	{
		// Token: 0x0600CBAD RID: 52141 RVA: 0x001DFE24 File Offset: 0x001DE024
		public static string ToEnumString(this EVisualNovelShakeIntensity value)
		{
			string result;
			if (value != EVisualNovelShakeIntensity.Weak)
			{
				if (value != EVisualNovelShakeIntensity.Strong)
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

		// Token: 0x0600CBAE RID: 52142 RVA: 0x001DFE5C File Offset: 0x001DE05C
		public static EVisualNovelShakeIntensity FromString(string name)
		{
			EVisualNovelShakeIntensity result;
			if (!EVisualNovelShakeIntensityExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelShakeIntensity 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBAF RID: 52143 RVA: 0x001DFE85 File Offset: 0x001DE085
		public static bool TryFromString(string name, out EVisualNovelShakeIntensity value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelShakeIntensity.Weak;
				return false;
			}
			if (name == "Weak")
			{
				value = EVisualNovelShakeIntensity.Weak;
				return true;
			}
			if (!(name == "Strong"))
			{
				value = EVisualNovelShakeIntensity.Weak;
				return false;
			}
			value = EVisualNovelShakeIntensity.Strong;
			return true;
		}

		// Token: 0x0600CBB0 RID: 52144 RVA: 0x001DFEBE File Offset: 0x001DE0BE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Weak",
				"Strong"
			};
		}

		// Token: 0x0600CBB1 RID: 52145 RVA: 0x001DFED6 File Offset: 0x001DE0D6
		public static EVisualNovelShakeIntensity[] GetValues()
		{
			return new EVisualNovelShakeIntensity[]
			{
				EVisualNovelShakeIntensity.Weak,
				EVisualNovelShakeIntensity.Strong
			};
		}

		// Token: 0x0600CBB2 RID: 52146 RVA: 0x001DFEE2 File Offset: 0x001DE0E2
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
