using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000952 RID: 2386
	public static class EGraph3dEffectTypeExtensions
	{
		// Token: 0x060035A2 RID: 13730 RVA: 0x0008BE18 File Offset: 0x0008A018
		public static string ToEnumString(this EGraph3dEffectType value)
		{
			string result;
			if (value == EGraph3dEffectType.FireBoxFish)
			{
				result = "FireBoxFish";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060035A3 RID: 13731 RVA: 0x0008BE40 File Offset: 0x0008A040
		public static EGraph3dEffectType FromString(string name)
		{
			EGraph3dEffectType result;
			if (!EGraph3dEffectTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGraph3dEffectType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060035A4 RID: 13732 RVA: 0x0008BE69 File Offset: 0x0008A069
		public static bool TryFromString(string name, out EGraph3dEffectType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGraph3dEffectType.FireBoxFish;
				return false;
			}
			if (name == "FireBoxFish")
			{
				value = EGraph3dEffectType.FireBoxFish;
				return true;
			}
			value = EGraph3dEffectType.FireBoxFish;
			return false;
		}

		// Token: 0x060035A5 RID: 13733 RVA: 0x0008BE8E File Offset: 0x0008A08E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FireBoxFish"
			};
		}

		// Token: 0x060035A6 RID: 13734 RVA: 0x0008BE9E File Offset: 0x0008A09E
		public static EGraph3dEffectType[] GetValues()
		{
			return new EGraph3dEffectType[1];
		}

		// Token: 0x060035A7 RID: 13735 RVA: 0x0008BEA6 File Offset: 0x0008A0A6
		public static string[] GetNames()
		{
			return new string[]
			{
				"FireBoxFish"
			};
		}
	}
}
