using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020022B7 RID: 8887
	public static class EBattleSettlementBgmTypeExtensions
	{
		// Token: 0x0600C2B6 RID: 49846 RVA: 0x001C73A4 File Offset: 0x001C55A4
		public static string ToEnumString(this EBattleSettlementBgmType value)
		{
			string result;
			if (value == EBattleSettlementBgmType.BattleSoundWave)
			{
				result = "BattleSoundWave";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0600C2B7 RID: 49847 RVA: 0x001C73CC File Offset: 0x001C55CC
		public static EBattleSettlementBgmType FromString(string name)
		{
			EBattleSettlementBgmType result;
			if (!EBattleSettlementBgmTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBattleSettlementBgmType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C2B8 RID: 49848 RVA: 0x001C73F5 File Offset: 0x001C55F5
		public static bool TryFromString(string name, out EBattleSettlementBgmType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBattleSettlementBgmType.BattleSoundWave;
				return false;
			}
			if (name == "BattleSoundWave")
			{
				value = EBattleSettlementBgmType.BattleSoundWave;
				return true;
			}
			value = EBattleSettlementBgmType.BattleSoundWave;
			return false;
		}

		// Token: 0x0600C2B9 RID: 49849 RVA: 0x001C741A File Offset: 0x001C561A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BattleSoundWave"
			};
		}

		// Token: 0x0600C2BA RID: 49850 RVA: 0x001C742A File Offset: 0x001C562A
		public static EBattleSettlementBgmType[] GetValues()
		{
			return new EBattleSettlementBgmType[1];
		}

		// Token: 0x0600C2BB RID: 49851 RVA: 0x001C7432 File Offset: 0x001C5632
		public static string[] GetNames()
		{
			return new string[]
			{
				"BattleSoundWave"
			};
		}
	}
}
