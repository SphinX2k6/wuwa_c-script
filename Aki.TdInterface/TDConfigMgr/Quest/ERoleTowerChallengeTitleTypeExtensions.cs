using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013C0 RID: 5056
	public static class ERoleTowerChallengeTitleTypeExtensions
	{
		// Token: 0x0600713A RID: 28986 RVA: 0x0010E384 File Offset: 0x0010C584
		public static string ToEnumString(this ERoleTowerChallengeTitleType value)
		{
			string result;
			switch (value)
			{
			case ERoleTowerChallengeTitleType.KillProgress:
				result = "KillProgress";
				break;
			case ERoleTowerChallengeTitleType.PhantomExp:
				result = "PhantomExp";
				break;
			case ERoleTowerChallengeTitleType.CurrentFloor:
				result = "CurrentFloor";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600713B RID: 28987 RVA: 0x0010E3CC File Offset: 0x0010C5CC
		public static ERoleTowerChallengeTitleType FromString(string name)
		{
			ERoleTowerChallengeTitleType result;
			if (!ERoleTowerChallengeTitleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleTowerChallengeTitleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600713C RID: 28988 RVA: 0x0010E3F8 File Offset: 0x0010C5F8
		public static bool TryFromString(string name, out ERoleTowerChallengeTitleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ERoleTowerChallengeTitleType.KillProgress;
				return false;
			}
			if (name == "KillProgress")
			{
				value = ERoleTowerChallengeTitleType.KillProgress;
				return true;
			}
			if (name == "PhantomExp")
			{
				value = ERoleTowerChallengeTitleType.PhantomExp;
				return true;
			}
			if (!(name == "CurrentFloor"))
			{
				value = ERoleTowerChallengeTitleType.KillProgress;
				return false;
			}
			value = ERoleTowerChallengeTitleType.CurrentFloor;
			return true;
		}

		// Token: 0x0600713D RID: 28989 RVA: 0x0010E44E File Offset: 0x0010C64E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KillProgress",
				"PhantomExp",
				"CurrentFloor"
			};
		}

		// Token: 0x0600713E RID: 28990 RVA: 0x0010E46E File Offset: 0x0010C66E
		public static ERoleTowerChallengeTitleType[] GetValues()
		{
			return new ERoleTowerChallengeTitleType[]
			{
				ERoleTowerChallengeTitleType.KillProgress,
				ERoleTowerChallengeTitleType.PhantomExp,
				ERoleTowerChallengeTitleType.CurrentFloor
			};
		}

		// Token: 0x0600713F RID: 28991 RVA: 0x0010E47E File Offset: 0x0010C67E
		public static string[] GetNames()
		{
			return new string[]
			{
				"KillProgress",
				"PhantomExp",
				"CurrentFloor"
			};
		}
	}
}
