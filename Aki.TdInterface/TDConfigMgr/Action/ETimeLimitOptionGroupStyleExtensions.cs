using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002710 RID: 10000
	public static class ETimeLimitOptionGroupStyleExtensions
	{
		// Token: 0x0600D722 RID: 55074 RVA: 0x001F6D5C File Offset: 0x001F4F5C
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

		// Token: 0x0600D723 RID: 55075 RVA: 0x001F6D84 File Offset: 0x001F4F84
		public static ETimeLimitOptionGroupStyle FromString(string name)
		{
			ETimeLimitOptionGroupStyle result;
			if (!ETimeLimitOptionGroupStyleExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETimeLimitOptionGroupStyle 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D724 RID: 55076 RVA: 0x001F6DAD File Offset: 0x001F4FAD
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

		// Token: 0x0600D725 RID: 55077 RVA: 0x001F6DD2 File Offset: 0x001F4FD2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default"
			};
		}

		// Token: 0x0600D726 RID: 55078 RVA: 0x001F6DE2 File Offset: 0x001F4FE2
		public static ETimeLimitOptionGroupStyle[] GetValues()
		{
			return new ETimeLimitOptionGroupStyle[1];
		}

		// Token: 0x0600D727 RID: 55079 RVA: 0x001F6DEA File Offset: 0x001F4FEA
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default"
			};
		}
	}
}
