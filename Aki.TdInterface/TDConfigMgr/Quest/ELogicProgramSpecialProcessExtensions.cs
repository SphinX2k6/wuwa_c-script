using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001394 RID: 5012
	public static class ELogicProgramSpecialProcessExtensions
	{
		// Token: 0x06007074 RID: 28788 RVA: 0x0010C374 File Offset: 0x0010A574
		public static string ToEnumString(this ELogicProgramSpecialProcess value)
		{
			string result;
			if (value == ELogicProgramSpecialProcess.DisableURO)
			{
				result = "DisableURO";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06007075 RID: 28789 RVA: 0x0010C39C File Offset: 0x0010A59C
		public static ELogicProgramSpecialProcess FromString(string name)
		{
			ELogicProgramSpecialProcess result;
			if (!ELogicProgramSpecialProcessExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELogicProgramSpecialProcess 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007076 RID: 28790 RVA: 0x0010C3C5 File Offset: 0x0010A5C5
		public static bool TryFromString(string name, out ELogicProgramSpecialProcess value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELogicProgramSpecialProcess.DisableURO;
				return false;
			}
			if (name == "DisableURO")
			{
				value = ELogicProgramSpecialProcess.DisableURO;
				return true;
			}
			value = ELogicProgramSpecialProcess.DisableURO;
			return false;
		}

		// Token: 0x06007077 RID: 28791 RVA: 0x0010C3EA File Offset: 0x0010A5EA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"DisableURO"
			};
		}

		// Token: 0x06007078 RID: 28792 RVA: 0x0010C3FA File Offset: 0x0010A5FA
		public static ELogicProgramSpecialProcess[] GetValues()
		{
			return new ELogicProgramSpecialProcess[1];
		}

		// Token: 0x06007079 RID: 28793 RVA: 0x0010C402 File Offset: 0x0010A602
		public static string[] GetNames()
		{
			return new string[]
			{
				"DisableURO"
			};
		}
	}
}
