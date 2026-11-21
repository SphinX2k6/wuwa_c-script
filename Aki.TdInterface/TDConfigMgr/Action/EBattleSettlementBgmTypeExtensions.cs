using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002526 RID: 9510
	public static class EBattleSettlementBgmTypeExtensions
	{
		// Token: 0x0600CE85 RID: 52869 RVA: 0x001DF1AC File Offset: 0x001DD3AC
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

		// Token: 0x0600CE86 RID: 52870 RVA: 0x001DF1D4 File Offset: 0x001DD3D4
		public static EBattleSettlementBgmType FromString(string name)
		{
			EBattleSettlementBgmType result;
			if (!EBattleSettlementBgmTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBattleSettlementBgmType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CE87 RID: 52871 RVA: 0x001DF1FD File Offset: 0x001DD3FD
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

		// Token: 0x0600CE88 RID: 52872 RVA: 0x001DF222 File Offset: 0x001DD422
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BattleSoundWave"
			};
		}

		// Token: 0x0600CE89 RID: 52873 RVA: 0x001DF232 File Offset: 0x001DD432
		public static EBattleSettlementBgmType[] GetValues()
		{
			return new EBattleSettlementBgmType[1];
		}

		// Token: 0x0600CE8A RID: 52874 RVA: 0x001DF23A File Offset: 0x001DD43A
		public static string[] GetNames()
		{
			return new string[]
			{
				"BattleSoundWave"
			};
		}
	}
}
