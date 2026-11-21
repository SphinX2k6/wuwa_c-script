using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020026A0 RID: 9888
	public static class ESetBattleStateTypeExtensions
	{
		// Token: 0x0600D52A RID: 54570 RVA: 0x001EF418 File Offset: 0x001ED618
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

		// Token: 0x0600D52B RID: 54571 RVA: 0x001EF460 File Offset: 0x001ED660
		public static ESetBattleStateType FromString(string name)
		{
			ESetBattleStateType result;
			if (!ESetBattleStateTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESetBattleStateType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D52C RID: 54572 RVA: 0x001EF48C File Offset: 0x001ED68C
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

		// Token: 0x0600D52D RID: 54573 RVA: 0x001EF4E2 File Offset: 0x001ED6E2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SetBattleTag",
				"NotifyMonsterPerception",
				"NotifyMonsterPlayStandbyTags"
			};
		}

		// Token: 0x0600D52E RID: 54574 RVA: 0x001EF502 File Offset: 0x001ED702
		public static ESetBattleStateType[] GetValues()
		{
			return new ESetBattleStateType[]
			{
				ESetBattleStateType.SetBattleTag,
				ESetBattleStateType.NotifyMonsterPerception,
				ESetBattleStateType.NotifyMonsterPlayStandbyTags
			};
		}

		// Token: 0x0600D52F RID: 54575 RVA: 0x001EF512 File Offset: 0x001ED712
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
