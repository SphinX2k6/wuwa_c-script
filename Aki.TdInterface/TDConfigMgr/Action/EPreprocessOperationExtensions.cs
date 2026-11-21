using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002676 RID: 9846
	public static class EPreprocessOperationExtensions
	{
		// Token: 0x0600D46D RID: 54381 RVA: 0x001EDBB8 File Offset: 0x001EBDB8
		public static string ToEnumString(this EPreprocessOperation value)
		{
			string result;
			if (value == EPreprocessOperation.FloatingSubtitleLanguageDiff)
			{
				result = "FloatingSubtitleLanguageDiff";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600D46E RID: 54382 RVA: 0x001EDBE0 File Offset: 0x001EBDE0
		public static EPreprocessOperation FromString(string name)
		{
			EPreprocessOperation result;
			if (!EPreprocessOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPreprocessOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D46F RID: 54383 RVA: 0x001EDC09 File Offset: 0x001EBE09
		public static bool TryFromString(string name, out EPreprocessOperation value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPreprocessOperation.FloatingSubtitleLanguageDiff;
				return false;
			}
			if (name == "FloatingSubtitleLanguageDiff")
			{
				value = EPreprocessOperation.FloatingSubtitleLanguageDiff;
				return true;
			}
			value = EPreprocessOperation.FloatingSubtitleLanguageDiff;
			return false;
		}

		// Token: 0x0600D470 RID: 54384 RVA: 0x001EDC2E File Offset: 0x001EBE2E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FloatingSubtitleLanguageDiff"
			};
		}

		// Token: 0x0600D471 RID: 54385 RVA: 0x001EDC3E File Offset: 0x001EBE3E
		public static EPreprocessOperation[] GetValues()
		{
			return new EPreprocessOperation[1];
		}

		// Token: 0x0600D472 RID: 54386 RVA: 0x001EDC46 File Offset: 0x001EBE46
		public static string[] GetNames()
		{
			return new string[]
			{
				"FloatingSubtitleLanguageDiff"
			};
		}
	}
}
