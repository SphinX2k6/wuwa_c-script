using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B9 RID: 8889
	public static class EBattleStatePerceptionBehaviorExtensions
	{
		// Token: 0x0600C2BF RID: 49855 RVA: 0x001C7480 File Offset: 0x001C5680
		public static string ToEnumString(this EBattleStatePerceptionBehavior value)
		{
			string result;
			if (value != EBattleStatePerceptionBehavior.NotifyGatherToPlayer)
			{
				if (value != EBattleStatePerceptionBehavior.NotifyGatherToEntity)
				{
					result = value.ToString();
				}
				else
				{
					result = "NotifyGatherToEntity";
				}
			}
			else
			{
				result = "NotifyGatherToPlayer";
			}
			return result;
		}

		// Token: 0x0600C2C0 RID: 49856 RVA: 0x001C74B8 File Offset: 0x001C56B8
		public static EBattleStatePerceptionBehavior FromString(string name)
		{
			EBattleStatePerceptionBehavior result;
			if (!EBattleStatePerceptionBehaviorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBattleStatePerceptionBehavior 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2C1 RID: 49857 RVA: 0x001C74E1 File Offset: 0x001C56E1
		public static bool TryFromString(string name, out EBattleStatePerceptionBehavior value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				return false;
			}
			if (name == "NotifyGatherToPlayer")
			{
				value = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				return true;
			}
			if (!(name == "NotifyGatherToEntity"))
			{
				value = EBattleStatePerceptionBehavior.NotifyGatherToPlayer;
				return false;
			}
			value = EBattleStatePerceptionBehavior.NotifyGatherToEntity;
			return true;
		}

		// Token: 0x0600C2C2 RID: 49858 RVA: 0x001C751A File Offset: 0x001C571A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NotifyGatherToPlayer",
				"NotifyGatherToEntity"
			};
		}

		// Token: 0x0600C2C3 RID: 49859 RVA: 0x001C7532 File Offset: 0x001C5732
		public static EBattleStatePerceptionBehavior[] GetValues()
		{
			return new EBattleStatePerceptionBehavior[]
			{
				EBattleStatePerceptionBehavior.NotifyGatherToPlayer,
				EBattleStatePerceptionBehavior.NotifyGatherToEntity
			};
		}

		// Token: 0x0600C2C4 RID: 49860 RVA: 0x001C753E File Offset: 0x001C573E
		public static string[] GetNames()
		{
			return new string[]
			{
				"NotifyGatherToPlayer",
				"NotifyGatherToEntity"
			};
		}
	}
}
