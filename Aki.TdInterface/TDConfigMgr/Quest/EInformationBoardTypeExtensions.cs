using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200138A RID: 5002
	public static class EInformationBoardTypeExtensions
	{
		// Token: 0x06007047 RID: 28743 RVA: 0x0010B8CC File Offset: 0x00109ACC
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

		// Token: 0x06007048 RID: 28744 RVA: 0x0010B8F4 File Offset: 0x00109AF4
		public static EInformationBoardType FromString(string name)
		{
			EInformationBoardType result;
			if (!EInformationBoardTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EInformationBoardType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x0010B91D File Offset: 0x00109B1D
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

		// Token: 0x0600704A RID: 28746 RVA: 0x0010B942 File Offset: 0x00109B42
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DangoAbyss"
			};
		}

		// Token: 0x0600704B RID: 28747 RVA: 0x0010B952 File Offset: 0x00109B52
		public static EInformationBoardType[] GetValues()
		{
			return new EInformationBoardType[1];
		}

		// Token: 0x0600704C RID: 28748 RVA: 0x0010B95A File Offset: 0x00109B5A
		public static string[] GetNames()
		{
			return new string[]
			{
				"DangoAbyss"
			};
		}
	}
}
