using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001240 RID: 4672
	public static class EFlagChallengeSystemVarTypeExtensions
	{
		// Token: 0x060069C7 RID: 27079 RVA: 0x000FD770 File Offset: 0x000FB970
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

		// Token: 0x060069C8 RID: 27080 RVA: 0x000FD798 File Offset: 0x000FB998
		public static EFlagChallengeSystemVarType FromString(string name)
		{
			EFlagChallengeSystemVarType result;
			if (!EFlagChallengeSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EFlagChallengeSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060069C9 RID: 27081 RVA: 0x000FD7C1 File Offset: 0x000FB9C1
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

		// Token: 0x060069CA RID: 27082 RVA: 0x000FD7E6 File Offset: 0x000FB9E6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"IsCompleted"
			};
		}

		// Token: 0x060069CB RID: 27083 RVA: 0x000FD7F6 File Offset: 0x000FB9F6
		public static EFlagChallengeSystemVarType[] GetValues()
		{
			return new EFlagChallengeSystemVarType[1];
		}

		// Token: 0x060069CC RID: 27084 RVA: 0x000FD7FE File Offset: 0x000FB9FE
		public static string[] GetNames()
		{
			return new string[]
			{
				"IsCompleted"
			};
		}
	}
}
