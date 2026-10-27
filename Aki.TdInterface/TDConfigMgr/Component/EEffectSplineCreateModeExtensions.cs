using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092C RID: 2348
	public static class EEffectSplineCreateModeExtensions
	{
		// Token: 0x060034F7 RID: 13559 RVA: 0x0008A614 File Offset: 0x00088814
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

		// Token: 0x060034F8 RID: 13560 RVA: 0x0008A64C File Offset: 0x0008884C
		public static EEffectSplineCreateMode FromString(string name)
		{
			EEffectSplineCreateMode result;
			if (!EEffectSplineCreateModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEffectSplineCreateMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x0008A675 File Offset: 0x00088875
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

		// Token: 0x060034FA RID: 13562 RVA: 0x0008A6AE File Offset: 0x000888AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"WholeLine",
				"EquidistantPoint"
			};
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x0008A6C6 File Offset: 0x000888C6
		public static EEffectSplineCreateMode[] GetValues()
		{
			return new EEffectSplineCreateMode[]
			{
				EEffectSplineCreateMode.WholeLine,
				EEffectSplineCreateMode.EquidistantPoint
			};
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x0008A6D2 File Offset: 0x000888D2
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
