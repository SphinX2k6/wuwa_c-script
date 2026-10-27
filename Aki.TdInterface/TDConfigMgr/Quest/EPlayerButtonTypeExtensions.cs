using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001262 RID: 4706
	public static class EPlayerButtonTypeExtensions
	{
		// Token: 0x06006A60 RID: 27232 RVA: 0x000FEF14 File Offset: 0x000FD114
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

		// Token: 0x06006A61 RID: 27233 RVA: 0x000FEF4C File Offset: 0x000FD14C
		public static EPlayerButtonType FromString(string name)
		{
			EPlayerButtonType result;
			if (!EPlayerButtonTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EPlayerButtonType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A62 RID: 27234 RVA: 0x000FEF75 File Offset: 0x000FD175
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

		// Token: 0x06006A63 RID: 27235 RVA: 0x000FEFAE File Offset: 0x000FD1AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"ChallengeAgain",
				"ExitChallenge"
			};
		}

		// Token: 0x06006A64 RID: 27236 RVA: 0x000FEFC6 File Offset: 0x000FD1C6
		public static EPlayerButtonType[] GetValues()
		{
			return new EPlayerButtonType[]
			{
				EPlayerButtonType.ChallengeAgain,
				EPlayerButtonType.ExitChallenge
			};
		}

		// Token: 0x06006A65 RID: 27237 RVA: 0x000FEFD2 File Offset: 0x000FD1D2
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
