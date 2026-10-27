using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023DF RID: 9183
	public static class EPreprocessOperationExtensions
	{
		// Token: 0x0600C7EA RID: 51178 RVA: 0x001D440C File Offset: 0x001D260C
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

		// Token: 0x0600C7EB RID: 51179 RVA: 0x001D4434 File Offset: 0x001D2634
		public static EPreprocessOperation FromString(string name)
		{
			EPreprocessOperation result;
			if (!EPreprocessOperationExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPreprocessOperation 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7EC RID: 51180 RVA: 0x001D445D File Offset: 0x001D265D
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

		// Token: 0x0600C7ED RID: 51181 RVA: 0x001D4482 File Offset: 0x001D2682
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"FloatingSubtitleLanguageDiff"
			};
		}

		// Token: 0x0600C7EE RID: 51182 RVA: 0x001D4492 File Offset: 0x001D2692
		public static EPreprocessOperation[] GetValues()
		{
			return new EPreprocessOperation[1];
		}

		// Token: 0x0600C7EF RID: 51183 RVA: 0x001D449A File Offset: 0x001D269A
		public static string[] GetNames()
		{
			return new string[]
			{
				"FloatingSubtitleLanguageDiff"
			};
		}
	}
}
