using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001280 RID: 4736
	public static class ERoleTowerChallengeTitleTypeExtensions
	{
		// Token: 0x06006AE7 RID: 27367 RVA: 0x00100758 File Offset: 0x000FE958
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

		// Token: 0x06006AE8 RID: 27368 RVA: 0x001007A0 File Offset: 0x000FE9A0
		public static ERoleTowerChallengeTitleType FromString(string name)
		{
			ERoleTowerChallengeTitleType result;
			if (!ERoleTowerChallengeTitleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ERoleTowerChallengeTitleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AE9 RID: 27369 RVA: 0x001007CC File Offset: 0x000FE9CC
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

		// Token: 0x06006AEA RID: 27370 RVA: 0x00100822 File Offset: 0x000FEA22
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"KillProgress",
				"PhantomExp",
				"CurrentFloor"
			};
		}

		// Token: 0x06006AEB RID: 27371 RVA: 0x00100842 File Offset: 0x000FEA42
		public static ERoleTowerChallengeTitleType[] GetValues()
		{
			return new ERoleTowerChallengeTitleType[]
			{
				ERoleTowerChallengeTitleType.KillProgress,
				ERoleTowerChallengeTitleType.PhantomExp,
				ERoleTowerChallengeTitleType.CurrentFloor
			};
		}

		// Token: 0x06006AEC RID: 27372 RVA: 0x00100852 File Offset: 0x000FEA52
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
