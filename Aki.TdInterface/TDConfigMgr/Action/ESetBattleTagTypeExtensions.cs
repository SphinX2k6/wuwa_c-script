using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A2 RID: 9890
	public static class ESetBattleTagTypeExtensions
	{
		// Token: 0x0600D533 RID: 54579 RVA: 0x001EF570 File Offset: 0x001ED770
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

		// Token: 0x0600D534 RID: 54580 RVA: 0x001EF5B8 File Offset: 0x001ED7B8
		public static ESetBattleTagType FromString(string name)
		{
			ESetBattleTagType result;
			if (!ESetBattleTagTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetBattleTagType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D535 RID: 54581 RVA: 0x001EF5E4 File Offset: 0x001ED7E4
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

		// Token: 0x0600D536 RID: 54582 RVA: 0x001EF63A File Offset: 0x001ED83A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"怪物.common.关卡.通信专用.幻象落地开启",
				"怪物.common.关卡.通信专用.唤醒者",
				"怪物.common.关卡.睡觉"
			};
		}

		// Token: 0x0600D537 RID: 54583 RVA: 0x001EF65A File Offset: 0x001ED85A
		public static ESetBattleTagType[] GetValues()
		{
			return new ESetBattleTagType[]
			{
				ESetBattleTagType.BattleMonsterLanding,
				ESetBattleTagType.BattleFinalMonsterLanding,
				ESetBattleTagType.BattleMonsterSleep
			};
		}

		// Token: 0x0600D538 RID: 54584 RVA: 0x001EF66A File Offset: 0x001ED86A
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
