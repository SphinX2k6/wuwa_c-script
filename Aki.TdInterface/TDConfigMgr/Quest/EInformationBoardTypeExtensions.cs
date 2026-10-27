using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200124A RID: 4682
	public static class EInformationBoardTypeExtensions
	{
		// Token: 0x060069F4 RID: 27124 RVA: 0x000FDCA0 File Offset: 0x000FBEA0
		public static string ToEnumString(this EInformationBoardType value)
		{
			string result;
			if (value == EInformationBoardType.DangoAbyss)
			{
				result = "DangoAbyss";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x060069F5 RID: 27125 RVA: 0x000FDCC8 File Offset: 0x000FBEC8
		public static EInformationBoardType FromString(string name)
		{
			EInformationBoardType result;
			if (!EInformationBoardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInformationBoardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069F6 RID: 27126 RVA: 0x000FDCF1 File Offset: 0x000FBEF1
		public static bool TryFromString(string name, out EInformationBoardType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EInformationBoardType.DangoAbyss;
				return false;
			}
			if (name == "DangoAbyss")
			{
				value = EInformationBoardType.DangoAbyss;
				return true;
			}
			value = EInformationBoardType.DangoAbyss;
			return false;
		}

		// Token: 0x060069F7 RID: 27127 RVA: 0x000FDD16 File Offset: 0x000FBF16
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DangoAbyss"
			};
		}

		// Token: 0x060069F8 RID: 27128 RVA: 0x000FDD26 File Offset: 0x000FBF26
		public static EInformationBoardType[] GetValues()
		{
			return new EInformationBoardType[1];
		}

		// Token: 0x060069F9 RID: 27129 RVA: 0x000FDD2E File Offset: 0x000FBF2E
		public static string[] GetNames()
		{
			return new string[]
			{
				"DangoAbyss"
			};
		}
	}
}
