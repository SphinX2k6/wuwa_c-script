using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002403 RID: 9219
	public static class ESetBattleTagTypeExtensions
	{
		// Token: 0x0600C88C RID: 51340 RVA: 0x001D5974 File Offset: 0x001D3B74
		public static string ToEnumString(this ESetBattleTagType value)
		{
			string result;
			switch (value)
			{
			case ESetBattleTagType.BattleMonsterLanding:
				result = "怪物.common.关卡.通信专用.幻象落地开启";
				break;
			case ESetBattleTagType.BattleFinalMonsterLanding:
				result = "怪物.common.关卡.通信专用.唤醒者";
				break;
			case ESetBattleTagType.BattleMonsterSleep:
				result = "怪物.common.关卡.睡觉";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C88D RID: 51341 RVA: 0x001D59BC File Offset: 0x001D3BBC
		public static ESetBattleTagType FromString(string name)
		{
			ESetBattleTagType result;
			if (!ESetBattleTagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetBattleTagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C88E RID: 51342 RVA: 0x001D59E8 File Offset: 0x001D3BE8
		public static bool TryFromString(string name, out ESetBattleTagType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetBattleTagType.BattleMonsterLanding;
				return false;
			}
			if (name == "怪物.common.关卡.通信专用.幻象落地开启")
			{
				value = ESetBattleTagType.BattleMonsterLanding;
				return true;
			}
			if (name == "怪物.common.关卡.通信专用.唤醒者")
			{
				value = ESetBattleTagType.BattleFinalMonsterLanding;
				return true;
			}
			if (!(name == "怪物.common.关卡.睡觉"))
			{
				value = ESetBattleTagType.BattleMonsterLanding;
				return false;
			}
			value = ESetBattleTagType.BattleMonsterSleep;
			return true;
		}

		// Token: 0x0600C88F RID: 51343 RVA: 0x001D5A3E File Offset: 0x001D3C3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"怪物.common.关卡.通信专用.幻象落地开启",
				"怪物.common.关卡.通信专用.唤醒者",
				"怪物.common.关卡.睡觉"
			};
		}

		// Token: 0x0600C890 RID: 51344 RVA: 0x001D5A5E File Offset: 0x001D3C5E
		public static ESetBattleTagType[] GetValues()
		{
			return new ESetBattleTagType[]
			{
				ESetBattleTagType.BattleMonsterLanding,
				ESetBattleTagType.BattleFinalMonsterLanding,
				ESetBattleTagType.BattleMonsterSleep
			};
		}

		// Token: 0x0600C891 RID: 51345 RVA: 0x001D5A6E File Offset: 0x001D3C6E
		public static string[] GetNames()
		{
			return new string[]
			{
				"BattleMonsterLanding",
				"BattleFinalMonsterLanding",
				"BattleMonsterSleep"
			};
		}
	}
}
