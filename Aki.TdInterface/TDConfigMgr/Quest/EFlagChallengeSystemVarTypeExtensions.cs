using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001380 RID: 4992
	public static class EFlagChallengeSystemVarTypeExtensions
	{
		// Token: 0x0600701A RID: 28698 RVA: 0x0010B39C File Offset: 0x0010959C
		public static string ToEnumString(this EFlagChallengeSystemVarType value)
		{
			string result;
			if (value == EFlagChallengeSystemVarType.IsCompleted)
			{
				result = "IsCompleted";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600701B RID: 28699 RVA: 0x0010B3C4 File Offset: 0x001095C4
		public static EFlagChallengeSystemVarType FromString(string name)
		{
			EFlagChallengeSystemVarType result;
			if (!EFlagChallengeSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlagChallengeSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600701C RID: 28700 RVA: 0x0010B3ED File Offset: 0x001095ED
		public static bool TryFromString(string name, out EFlagChallengeSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EFlagChallengeSystemVarType.IsCompleted;
				return false;
			}
			if (name == "IsCompleted")
			{
				value = EFlagChallengeSystemVarType.IsCompleted;
				return true;
			}
			value = EFlagChallengeSystemVarType.IsCompleted;
			return false;
		}

		// Token: 0x0600701D RID: 28701 RVA: 0x0010B412 File Offset: 0x00109612
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"IsCompleted"
			};
		}

		// Token: 0x0600701E RID: 28702 RVA: 0x0010B422 File Offset: 0x00109622
		public static EFlagChallengeSystemVarType[] GetValues()
		{
			return new EFlagChallengeSystemVarType[1];
		}

		// Token: 0x0600701F RID: 28703 RVA: 0x0010B42A File Offset: 0x0010962A
		public static string[] GetNames()
		{
			return new string[]
			{
				"IsCompleted"
			};
		}
	}
}
