using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x020009D7 RID: 2519
	public static class EEffectAreaTypeExtensions
	{
		// Token: 0x0600385A RID: 14426 RVA: 0x000920B8 File Offset: 0x000902B8
		public static string ToEnumString(this EEffectAreaType value)
		{
			string result;
			if (value == EEffectAreaType.BuffArea)
			{
				result = "BuffArea";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600385B RID: 14427 RVA: 0x000920E0 File Offset: 0x000902E0
		public static EEffectAreaType FromString(string name)
		{
			EEffectAreaType result;
			if (!EEffectAreaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEffectAreaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600385C RID: 14428 RVA: 0x00092109 File Offset: 0x00090309
		public static bool TryFromString(string name, out EEffectAreaType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EEffectAreaType.BuffArea;
				return false;
			}
			if (name == "BuffArea")
			{
				value = EEffectAreaType.BuffArea;
				return true;
			}
			value = EEffectAreaType.BuffArea;
			return false;
		}

		// Token: 0x0600385D RID: 14429 RVA: 0x0009212E File Offset: 0x0009032E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BuffArea"
			};
		}

		// Token: 0x0600385E RID: 14430 RVA: 0x0009213E File Offset: 0x0009033E
		public static EEffectAreaType[] GetValues()
		{
			return new EEffectAreaType[1];
		}

		// Token: 0x0600385F RID: 14431 RVA: 0x00092146 File Offset: 0x00090346
		public static string[] GetNames()
		{
			return new string[]
			{
				"BuffArea"
			};
		}
	}
}
