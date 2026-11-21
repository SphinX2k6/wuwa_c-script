using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001360 RID: 4960
	public static class EAtomicProcessExtensions
	{
		// Token: 0x06006F8A RID: 28554 RVA: 0x00108784 File Offset: 0x00106984
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

		// Token: 0x06006F8B RID: 28555 RVA: 0x001087AC File Offset: 0x001069AC
		public static EAtomicProcess FromString(string name)
		{
			EAtomicProcess result;
			if (!EAtomicProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EAtomicProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006F8C RID: 28556 RVA: 0x001087D5 File Offset: 0x001069D5
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

		// Token: 0x06006F8D RID: 28557 RVA: 0x001087FA File Offset: 0x001069FA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"StoveCoreFall"
			};
		}

		// Token: 0x06006F8E RID: 28558 RVA: 0x0010880A File Offset: 0x00106A0A
		public static EAtomicProcess[] GetValues()
		{
			return new EAtomicProcess[1];
		}

		// Token: 0x06006F8F RID: 28559 RVA: 0x00108812 File Offset: 0x00106A12
		public static string[] GetNames()
		{
			return new string[]
			{
				"StoveCoreFall"
			};
		}
	}
}
