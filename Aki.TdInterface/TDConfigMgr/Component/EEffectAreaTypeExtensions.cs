using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x0200092A RID: 2346
	public static class EEffectAreaTypeExtensions
	{
		// Token: 0x060034EE RID: 13550 RVA: 0x0008A538 File Offset: 0x00088738
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

		// Token: 0x060034EF RID: 13551 RVA: 0x0008A560 File Offset: 0x00088760
		public static EEffectAreaType FromString(string name)
		{
			EEffectAreaType result;
			if (!EEffectAreaTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EEffectAreaType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x0008A589 File Offset: 0x00088789
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

		// Token: 0x060034F1 RID: 13553 RVA: 0x0008A5AE File Offset: 0x000887AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BuffArea"
			};
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x0008A5BE File Offset: 0x000887BE
		public static EEffectAreaType[] GetValues()
		{
			return new EEffectAreaType[1];
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x0008A5C6 File Offset: 0x000887C6
		public static string[] GetNames()
		{
			return new string[]
			{
				"BuffArea"
			};
		}
	}
}
