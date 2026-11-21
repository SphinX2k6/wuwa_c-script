using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002528 RID: 9512
	public static class EBattleStatePerceptionBehaviorExtensions
	{
		// Token: 0x0600CE8E RID: 52878 RVA: 0x001DF288 File Offset: 0x001DD488
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

		// Token: 0x0600CE8F RID: 52879 RVA: 0x001DF2C0 File Offset: 0x001DD4C0
		public static EBattleStatePerceptionBehavior FromString(string name)
		{
			EBattleStatePerceptionBehavior result;
			if (!EBattleStatePerceptionBehaviorExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBattleStatePerceptionBehavior 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE90 RID: 52880 RVA: 0x001DF2E9 File Offset: 0x001DD4E9
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

		// Token: 0x0600CE91 RID: 52881 RVA: 0x001DF322 File Offset: 0x001DD522
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"NotifyGatherToPlayer",
				"NotifyGatherToEntity"
			};
		}

		// Token: 0x0600CE92 RID: 52882 RVA: 0x001DF33A File Offset: 0x001DD53A
		public static EBattleStatePerceptionBehavior[] GetValues()
		{
			return new EBattleStatePerceptionBehavior[]
			{
				EBattleStatePerceptionBehavior.NotifyGatherToPlayer,
				EBattleStatePerceptionBehavior.NotifyGatherToEntity
			};
		}

		// Token: 0x0600CE93 RID: 52883 RVA: 0x001DF346 File Offset: 0x001DD546
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
