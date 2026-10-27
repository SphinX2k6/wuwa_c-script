using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200090C RID: 2316
	public static class EColorChangeStrategyOfSplineEffectExtensions
	{
		// Token: 0x06003467 RID: 13415 RVA: 0x00085C14 File Offset: 0x00083E14
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

		// Token: 0x06003468 RID: 13416 RVA: 0x00085C3C File Offset: 0x00083E3C
		public static EColorChangeStrategyOfSplineEffect FromString(string name)
		{
			EColorChangeStrategyOfSplineEffect result;
			if (!EColorChangeStrategyOfSplineEffectExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EColorChangeStrategyOfSplineEffect 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003469 RID: 13417 RVA: 0x00085C65 File Offset: 0x00083E65
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

		// Token: 0x0600346A RID: 13418 RVA: 0x00085C8A File Offset: 0x00083E8A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"RGB"
			};
		}

		// Token: 0x0600346B RID: 13419 RVA: 0x00085C9A File Offset: 0x00083E9A
		public static EColorChangeStrategyOfSplineEffect[] GetValues()
		{
			return new EColorChangeStrategyOfSplineEffect[1];
		}

		// Token: 0x0600346C RID: 13420 RVA: 0x00085CA2 File Offset: 0x00083EA2
		public static string[] GetNames()
		{
			return new string[]
			{
				"RGB"
			};
		}
	}
}
