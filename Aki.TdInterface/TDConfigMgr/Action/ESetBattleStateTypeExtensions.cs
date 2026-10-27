using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002401 RID: 9217
	public static class ESetBattleStateTypeExtensions
	{
		// Token: 0x0600C883 RID: 51331 RVA: 0x001D581C File Offset: 0x001D3A1C
		public static string ToEnumString(this ESetBattleStateType value)
		{
			string result;
			switch (value)
			{
			case ESetBattleStateType.SetBattleTag:
				result = "SetBattleTag";
				break;
			case ESetBattleStateType.NotifyMonsterPerception:
				result = "NotifyMonsterPerception";
				break;
			case ESetBattleStateType.NotifyMonsterPlayStandbyTags:
				result = "NotifyMonsterPlayStandbyTags";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600C884 RID: 51332 RVA: 0x001D5864 File Offset: 0x001D3A64
		public static ESetBattleStateType FromString(string name)
		{
			ESetBattleStateType result;
			if (!ESetBattleStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetBattleStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C885 RID: 51333 RVA: 0x001D5890 File Offset: 0x001D3A90
		public static bool TryFromString(string name, out ESetBattleStateType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESetBattleStateType.SetBattleTag;
				return false;
			}
			if (name == "SetBattleTag")
			{
				value = ESetBattleStateType.SetBattleTag;
				return true;
			}
			if (name == "NotifyMonsterPerception")
			{
				value = ESetBattleStateType.NotifyMonsterPerception;
				return true;
			}
			if (!(name == "NotifyMonsterPlayStandbyTags"))
			{
				value = ESetBattleStateType.SetBattleTag;
				return false;
			}
			value = ESetBattleStateType.NotifyMonsterPlayStandbyTags;
			return true;
		}

		// Token: 0x0600C886 RID: 51334 RVA: 0x001D58E6 File Offset: 0x001D3AE6
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetBattleTag",
				"NotifyMonsterPerception",
				"NotifyMonsterPlayStandbyTags"
			};
		}

		// Token: 0x0600C887 RID: 51335 RVA: 0x001D5906 File Offset: 0x001D3B06
		public static ESetBattleStateType[] GetValues()
		{
			return new ESetBattleStateType[]
			{
				ESetBattleStateType.SetBattleTag,
				ESetBattleStateType.NotifyMonsterPerception,
				ESetBattleStateType.NotifyMonsterPlayStandbyTags
			};
		}

		// Token: 0x0600C888 RID: 51336 RVA: 0x001D5916 File Offset: 0x001D3B16
		public static string[] GetNames()
		{
			return new string[]
			{
				"SetBattleTag",
				"NotifyMonsterPerception",
				"NotifyMonsterPlayStandbyTags"
			};
		}
	}
}
