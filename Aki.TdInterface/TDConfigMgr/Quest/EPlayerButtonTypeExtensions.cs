using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013A2 RID: 5026
	public static class EPlayerButtonTypeExtensions
	{
		// Token: 0x060070B3 RID: 28851 RVA: 0x0010CB40 File Offset: 0x0010AD40
		public static string ToEnumString(this EPlayerButtonType value)
		{
			string result;
			if (value != EPlayerButtonType.ChallengeAgain)
			{
				if (value != EPlayerButtonType.ExitChallenge)
				{
					result = value.ToString();
				}
				else
				{
					result = "ExitChallenge";
				}
			}
			else
			{
				result = "ChallengeAgain";
			}
			return result;
		}

		// Token: 0x060070B4 RID: 28852 RVA: 0x0010CB78 File Offset: 0x0010AD78
		public static EPlayerButtonType FromString(string name)
		{
			EPlayerButtonType result;
			if (!EPlayerButtonTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerButtonType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070B5 RID: 28853 RVA: 0x0010CBA1 File Offset: 0x0010ADA1
		public static bool TryFromString(string name, out EPlayerButtonType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EPlayerButtonType.ChallengeAgain;
				return false;
			}
			if (name == "ChallengeAgain")
			{
				value = EPlayerButtonType.ChallengeAgain;
				return true;
			}
			if (!(name == "ExitChallenge"))
			{
				value = EPlayerButtonType.ChallengeAgain;
				return false;
			}
			value = EPlayerButtonType.ExitChallenge;
			return true;
		}

		// Token: 0x060070B6 RID: 28854 RVA: 0x0010CBDA File Offset: 0x0010ADDA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChallengeAgain",
				"ExitChallenge"
			};
		}

		// Token: 0x060070B7 RID: 28855 RVA: 0x0010CBF2 File Offset: 0x0010ADF2
		public static EPlayerButtonType[] GetValues()
		{
			return new EPlayerButtonType[]
			{
				EPlayerButtonType.ChallengeAgain,
				EPlayerButtonType.ExitChallenge
			};
		}

		// Token: 0x060070B8 RID: 28856 RVA: 0x0010CBFE File Offset: 0x0010ADFE
		public static string[] GetNames()
		{
			return new string[]
			{
				"ChallengeAgain",
				"ExitChallenge"
			};
		}
	}
}
