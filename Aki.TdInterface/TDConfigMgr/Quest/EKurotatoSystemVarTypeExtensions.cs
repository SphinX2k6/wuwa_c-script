using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001250 RID: 4688
	public static class EKurotatoSystemVarTypeExtensions
	{
		// Token: 0x06006A0F RID: 27151 RVA: 0x000FE1B4 File Offset: 0x000FC3B4
		public static string ToEnumString(this EKurotatoSystemVarType value)
		{
			string result;
			switch (value)
			{
			case EKurotatoSystemVarType.Gold:
				result = "Gold";
				break;
			case EKurotatoSystemVarType.SpareGold:
				result = "SpareGold";
				break;
			case EKurotatoSystemVarType.RoleLevel:
				result = "RoleLevel";
				break;
			case EKurotatoSystemVarType.TotalRoleExp:
				result = "TotalRoleExp";
				break;
			case EKurotatoSystemVarType.Batch:
				result = "Batch";
				break;
			case EKurotatoSystemVarType.RealBatch:
				result = "RealBatch";
				break;
			case EKurotatoSystemVarType.BatchType:
				result = "BatchType";
				break;
			case EKurotatoSystemVarType.BatchConfigId:
				result = "BatchConfigId";
				break;
			case EKurotatoSystemVarType.MaxBatch:
				result = "MaxBatch";
				break;
			case EKurotatoSystemVarType.TreasureBoxCount:
				result = "TreasureBoxCount";
				break;
			case EKurotatoSystemVarType.UpgradeCount:
				result = "UpgradeCount";
				break;
			case EKurotatoSystemVarType.ConsecutiveKillCount:
				result = "ConsecutiveKillCount";
				break;
			case EKurotatoSystemVarType.GoldGainEfficiency:
				result = "GoldGainEfficiency";
				break;
			case EKurotatoSystemVarType.NeedRollback:
				result = "NeedRollback";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006A10 RID: 27152 RVA: 0x000FE280 File Offset: 0x000FC480
		public static EKurotatoSystemVarType FromString(string name)
		{
			EKurotatoSystemVarType result;
			if (!EKurotatoSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EKurotatoSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A11 RID: 27153 RVA: 0x000FE2AC File Offset: 0x000FC4AC
		public static bool TryFromString(string name, out EKurotatoSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EKurotatoSystemVarType.Gold;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 4:
					if (name == "Gold")
					{
						value = EKurotatoSystemVarType.Gold;
						return true;
					}
					break;
				case 5:
					if (name == "Batch")
					{
						value = EKurotatoSystemVarType.Batch;
						return true;
					}
					break;
				case 8:
					if (name == "MaxBatch")
					{
						value = EKurotatoSystemVarType.MaxBatch;
						return true;
					}
					break;
				case 9:
				{
					char c = name[1];
					if (c <= 'e')
					{
						if (c != 'a')
						{
							if (c == 'e')
							{
								if (name == "RealBatch")
								{
									value = EKurotatoSystemVarType.RealBatch;
									return true;
								}
							}
						}
						else if (name == "BatchType")
						{
							value = EKurotatoSystemVarType.BatchType;
							return true;
						}
					}
					else if (c != 'o')
					{
						if (c == 'p')
						{
							if (name == "SpareGold")
							{
								value = EKurotatoSystemVarType.SpareGold;
								return true;
							}
						}
					}
					else if (name == "RoleLevel")
					{
						value = EKurotatoSystemVarType.RoleLevel;
						return true;
					}
					break;
				}
				case 12:
				{
					char c = name[0];
					if (c != 'N')
					{
						if (c != 'T')
						{
							if (c == 'U')
							{
								if (name == "UpgradeCount")
								{
									value = EKurotatoSystemVarType.UpgradeCount;
									return true;
								}
							}
						}
						else if (name == "TotalRoleExp")
						{
							value = EKurotatoSystemVarType.TotalRoleExp;
							return true;
						}
					}
					else if (name == "NeedRollback")
					{
						value = EKurotatoSystemVarType.NeedRollback;
						return true;
					}
					break;
				}
				case 13:
					if (name == "BatchConfigId")
					{
						value = EKurotatoSystemVarType.BatchConfigId;
						return true;
					}
					break;
				case 16:
					if (name == "TreasureBoxCount")
					{
						value = EKurotatoSystemVarType.TreasureBoxCount;
						return true;
					}
					break;
				case 18:
					if (name == "GoldGainEfficiency")
					{
						value = EKurotatoSystemVarType.GoldGainEfficiency;
						return true;
					}
					break;
				case 20:
					if (name == "ConsecutiveKillCount")
					{
						value = EKurotatoSystemVarType.ConsecutiveKillCount;
						return true;
					}
					break;
				}
			}
			value = EKurotatoSystemVarType.Gold;
			return false;
		}

		// Token: 0x06006A12 RID: 27154 RVA: 0x000FE4CC File Offset: 0x000FC6CC
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Gold",
				"SpareGold",
				"RoleLevel",
				"TotalRoleExp",
				"Batch",
				"RealBatch",
				"BatchType",
				"BatchConfigId",
				"MaxBatch",
				"TreasureBoxCount",
				"UpgradeCount",
				"ConsecutiveKillCount",
				"GoldGainEfficiency",
				"NeedRollback"
			};
		}

		// Token: 0x06006A13 RID: 27155 RVA: 0x000FE555 File Offset: 0x000FC755
		public static EKurotatoSystemVarType[] GetValues()
		{
			return new EKurotatoSystemVarType[]
			{
				EKurotatoSystemVarType.Gold,
				EKurotatoSystemVarType.SpareGold,
				EKurotatoSystemVarType.RoleLevel,
				EKurotatoSystemVarType.TotalRoleExp,
				EKurotatoSystemVarType.Batch,
				EKurotatoSystemVarType.RealBatch,
				EKurotatoSystemVarType.BatchType,
				EKurotatoSystemVarType.BatchConfigId,
				EKurotatoSystemVarType.MaxBatch,
				EKurotatoSystemVarType.TreasureBoxCount,
				EKurotatoSystemVarType.UpgradeCount,
				EKurotatoSystemVarType.ConsecutiveKillCount,
				EKurotatoSystemVarType.GoldGainEfficiency,
				EKurotatoSystemVarType.NeedRollback
			};
		}

		// Token: 0x06006A14 RID: 27156 RVA: 0x000FE56C File Offset: 0x000FC76C
		public static string[] GetNames()
		{
			return new string[]
			{
				"Gold",
				"SpareGold",
				"RoleLevel",
				"TotalRoleExp",
				"Batch",
				"RealBatch",
				"BatchType",
				"BatchConfigId",
				"MaxBatch",
				"TreasureBoxCount",
				"UpgradeCount",
				"ConsecutiveKillCount",
				"GoldGainEfficiency",
				"NeedRollback"
			};
		}
	}
}
