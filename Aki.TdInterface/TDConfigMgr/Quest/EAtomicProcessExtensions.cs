using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001224 RID: 4644
	public static class EAtomicProcessExtensions
	{
		// Token: 0x06006949 RID: 26953 RVA: 0x000FAE78 File Offset: 0x000F9078
		public static string ToEnumString(this EAtomicProcess value)
		{
			string result;
			if (value == EAtomicProcess.StoveCoreFall)
			{
				result = "StoveCoreFall";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600694A RID: 26954 RVA: 0x000FAEA0 File Offset: 0x000F90A0
		public static EAtomicProcess FromString(string name)
		{
			EAtomicProcess result;
			if (!EAtomicProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAtomicProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600694B RID: 26955 RVA: 0x000FAEC9 File Offset: 0x000F90C9
		public static bool TryFromString(string name, out EAtomicProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EAtomicProcess.StoveCoreFall;
				return false;
			}
			if (name == "StoveCoreFall")
			{
				value = EAtomicProcess.StoveCoreFall;
				return true;
			}
			value = EAtomicProcess.StoveCoreFall;
			return false;
		}

		// Token: 0x0600694C RID: 26956 RVA: 0x000FAEEE File Offset: 0x000F90EE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StoveCoreFall"
			};
		}

		// Token: 0x0600694D RID: 26957 RVA: 0x000FAEFE File Offset: 0x000F90FE
		public static EAtomicProcess[] GetValues()
		{
			return new EAtomicProcess[1];
		}

		// Token: 0x0600694E RID: 26958 RVA: 0x000FAF06 File Offset: 0x000F9106
		public static string[] GetNames()
		{
			return new string[]
			{
				"StoveCoreFall"
			};
		}
	}
}
