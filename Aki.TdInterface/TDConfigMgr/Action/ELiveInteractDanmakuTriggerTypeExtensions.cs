using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020025F2 RID: 9714
	public static class ELiveInteractDanmakuTriggerTypeExtensions
	{
		// Token: 0x0600D21B RID: 53787 RVA: 0x001E8B9C File Offset: 0x001E6D9C
		public static string ToEnumString(this ELiveInteractDanmakuTriggerType value)
		{
			string result;
			switch (value)
			{
			case ELiveInteractDanmakuTriggerType.SkillGenre:
				result = "SkillGenre";
				break;
			case ELiveInteractDanmakuTriggerType.SkillId:
				result = "SkillId";
				break;
			case ELiveInteractDanmakuTriggerType.BattleEvent:
				result = "BattleEvent";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D21C RID: 53788 RVA: 0x001E8BE4 File Offset: 0x001E6DE4
		public static ELiveInteractDanmakuTriggerType FromString(string name)
		{
			ELiveInteractDanmakuTriggerType result;
			if (!ELiveInteractDanmakuTriggerTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ELiveInteractDanmakuTriggerType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D21D RID: 53789 RVA: 0x001E8C10 File Offset: 0x001E6E10
		public static bool TryFromString(string name, out ELiveInteractDanmakuTriggerType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ELiveInteractDanmakuTriggerType.SkillGenre;
				return false;
			}
			if (name == "SkillGenre")
			{
				value = ELiveInteractDanmakuTriggerType.SkillGenre;
				return true;
			}
			if (name == "SkillId")
			{
				value = ELiveInteractDanmakuTriggerType.SkillId;
				return true;
			}
			if (!(name == "BattleEvent"))
			{
				value = ELiveInteractDanmakuTriggerType.SkillGenre;
				return false;
			}
			value = ELiveInteractDanmakuTriggerType.BattleEvent;
			return true;
		}

		// Token: 0x0600D21E RID: 53790 RVA: 0x001E8C66 File Offset: 0x001E6E66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SkillGenre",
				"SkillId",
				"BattleEvent"
			};
		}

		// Token: 0x0600D21F RID: 53791 RVA: 0x001E8C86 File Offset: 0x001E6E86
		public static ELiveInteractDanmakuTriggerType[] GetValues()
		{
			return new ELiveInteractDanmakuTriggerType[]
			{
				ELiveInteractDanmakuTriggerType.SkillGenre,
				ELiveInteractDanmakuTriggerType.SkillId,
				ELiveInteractDanmakuTriggerType.BattleEvent
			};
		}

		// Token: 0x0600D220 RID: 53792 RVA: 0x001E8C96 File Offset: 0x001E6E96
		public static string[] GetNames()
		{
			return new string[]
			{
				"SkillGenre",
				"SkillId",
				"BattleEvent"
			};
		}
	}
}
