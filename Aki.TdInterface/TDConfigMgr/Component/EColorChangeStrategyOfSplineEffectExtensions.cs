using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009B9 RID: 2489
	public static class EColorChangeStrategyOfSplineEffectExtensions
	{
		// Token: 0x060037D3 RID: 14291 RVA: 0x0008D720 File Offset: 0x0008B920
		public static string ToEnumString(this EColorChangeStrategyOfSplineEffect value)
		{
			string result;
			if (value == EColorChangeStrategyOfSplineEffect.RGB)
			{
				result = "RGB";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060037D4 RID: 14292 RVA: 0x0008D748 File Offset: 0x0008B948
		public static EColorChangeStrategyOfSplineEffect FromString(string name)
		{
			EColorChangeStrategyOfSplineEffect result;
			if (!EColorChangeStrategyOfSplineEffectExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EColorChangeStrategyOfSplineEffect 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060037D5 RID: 14293 RVA: 0x0008D771 File Offset: 0x0008B971
		public static bool TryFromString(string name, out EColorChangeStrategyOfSplineEffect value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EColorChangeStrategyOfSplineEffect.RGB;
				return false;
			}
			if (name == "RGB")
			{
				value = EColorChangeStrategyOfSplineEffect.RGB;
				return true;
			}
			value = EColorChangeStrategyOfSplineEffect.RGB;
			return false;
		}

		// Token: 0x060037D6 RID: 14294 RVA: 0x0008D796 File Offset: 0x0008B996
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RGB"
			};
		}

		// Token: 0x060037D7 RID: 14295 RVA: 0x0008D7A6 File Offset: 0x0008B9A6
		public static EColorChangeStrategyOfSplineEffect[] GetValues()
		{
			return new EColorChangeStrategyOfSplineEffect[1];
		}

		// Token: 0x060037D8 RID: 14296 RVA: 0x0008D7AE File Offset: 0x0008B9AE
		public static string[] GetNames()
		{
			return new string[]
			{
				"RGB"
			};
		}
	}
}
