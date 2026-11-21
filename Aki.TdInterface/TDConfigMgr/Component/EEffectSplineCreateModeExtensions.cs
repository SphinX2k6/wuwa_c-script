using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D9 RID: 2521
	public static class EEffectSplineCreateModeExtensions
	{
		// Token: 0x06003863 RID: 14435 RVA: 0x00092194 File Offset: 0x00090394
		public static string ToEnumString(this EEffectSplineCreateMode value)
		{
			string result;
			if (value != EEffectSplineCreateMode.WholeLine)
			{
				if (value != EEffectSplineCreateMode.EquidistantPoint)
				{
					result = value.ToString();
				}
				else
				{
					result = "EquidistantPoint";
				}
			}
			else
			{
				result = "WholeLine";
			}
			return result;
		}

		// Token: 0x06003864 RID: 14436 RVA: 0x000921CC File Offset: 0x000903CC
		public static EEffectSplineCreateMode FromString(string name)
		{
			EEffectSplineCreateMode result;
			if (!EEffectSplineCreateModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEffectSplineCreateMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003865 RID: 14437 RVA: 0x000921F5 File Offset: 0x000903F5
		public static bool TryFromString(string name, out EEffectSplineCreateMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEffectSplineCreateMode.WholeLine;
				return false;
			}
			if (name == "WholeLine")
			{
				value = EEffectSplineCreateMode.WholeLine;
				return true;
			}
			if (!(name == "EquidistantPoint"))
			{
				value = EEffectSplineCreateMode.WholeLine;
				return false;
			}
			value = EEffectSplineCreateMode.EquidistantPoint;
			return true;
		}

		// Token: 0x06003866 RID: 14438 RVA: 0x0009222E File Offset: 0x0009042E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WholeLine",
				"EquidistantPoint"
			};
		}

		// Token: 0x06003867 RID: 14439 RVA: 0x00092246 File Offset: 0x00090446
		public static EEffectSplineCreateMode[] GetValues()
		{
			return new EEffectSplineCreateMode[]
			{
				EEffectSplineCreateMode.WholeLine,
				EEffectSplineCreateMode.EquidistantPoint
			};
		}

		// Token: 0x06003868 RID: 14440 RVA: 0x00092252 File Offset: 0x00090452
		public static string[] GetNames()
		{
			return new string[]
			{
				"WholeLine",
				"EquidistantPoint"
			};
		}
	}
}
