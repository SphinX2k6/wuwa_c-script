using System;

namespace CSharpScript.Game.Module.Kurotato
{
	// Token: 0x020046F2 RID: 18162
	public static class EKurotatoSystemVarTypeExtensions
	{
		// Token: 0x0602DA2F RID: 186927 RVA: 0x00CC1AE8 File Offset: 0x00CBFCE8
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

		// Token: 0x0602DA30 RID: 186928 RVA: 0x00CC1BB4 File Offset: 0x00CBFDB4
		public static EKurotatoSystemVarType FromString(string name)
		{
			EKurotatoSystemVarType result;
			if (!EKurotatoSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EKurotatoSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0602DA31 RID: 186929 RVA: 0x00CC1BE0 File Offset: 0x00CBFDE0
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

		// Token: 0x0602DA32 RID: 186930 RVA: 0x00CC1E00 File Offset: 0x00CC0000
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

		// Token: 0x0602DA33 RID: 186931 RVA: 0x00CC1E89 File Offset: 0x00CC0089
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

		// Token: 0x0602DA34 RID: 186932 RVA: 0x00CC1EA0 File Offset: 0x00CC00A0
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
