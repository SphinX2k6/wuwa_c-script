using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200246F RID: 9327
	public static class ETimeLimitOptionGroupStyleExtensions
	{
		// Token: 0x0600CA72 RID: 51826 RVA: 0x001DCCA8 File Offset: 0x001DAEA8
		public static string ToEnumString(this ETimeLimitOptionGroupStyle value)
		{
			string result;
			if (value == ETimeLimitOptionGroupStyle.Default)
			{
				result = "Default";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600CA73 RID: 51827 RVA: 0x001DCCD0 File Offset: 0x001DAED0
		public static ETimeLimitOptionGroupStyle FromString(string name)
		{
			ETimeLimitOptionGroupStyle result;
			if (!ETimeLimitOptionGroupStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeLimitOptionGroupStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CA74 RID: 51828 RVA: 0x001DCCF9 File Offset: 0x001DAEF9
		public static bool TryFromString(string name, out ETimeLimitOptionGroupStyle value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETimeLimitOptionGroupStyle.Default;
				return false;
			}
			if (name == "Default")
			{
				value = ETimeLimitOptionGroupStyle.Default;
				return true;
			}
			value = ETimeLimitOptionGroupStyle.Default;
			return false;
		}

		// Token: 0x0600CA75 RID: 51829 RVA: 0x001DCD1E File Offset: 0x001DAF1E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default"
			};
		}

		// Token: 0x0600CA76 RID: 51830 RVA: 0x001DCD2E File Offset: 0x001DAF2E
		public static ETimeLimitOptionGroupStyle[] GetValues()
		{
			return new ETimeLimitOptionGroupStyle[1];
		}

		// Token: 0x0600CA77 RID: 51831 RVA: 0x001DCD36 File Offset: 0x001DAF36
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default"
			};
		}
	}
}
