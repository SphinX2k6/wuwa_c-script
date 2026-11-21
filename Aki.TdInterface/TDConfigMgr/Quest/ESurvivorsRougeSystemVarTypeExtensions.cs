using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013DA RID: 5082
	public static class ESurvivorsRougeSystemVarTypeExtensions
	{
		// Token: 0x060071AF RID: 29103 RVA: 0x0010FA50 File Offset: 0x0010DC50
		public static string ToEnumString(this ESurvivorsRougeSystemVarType value)
		{
			string result;
			switch (value)
			{
			case ESurvivorsRougeSystemVarType.Gold:
				result = "Gold";
				break;
			case ESurvivorsRougeSystemVarType.Batch:
				result = "Batch";
				break;
			case ESurvivorsRougeSystemVarType.MaxBatch:
				result = "MaxBatch";
				break;
			case ESurvivorsRougeSystemVarType.EndlessBatchLimit:
				result = "EndlessBatchLimit";
				break;
			case ESurvivorsRougeSystemVarType.TreasureBoxCount:
				result = "TreasureBoxCount";
				break;
			case ESurvivorsRougeSystemVarType.ConsecutiveKillCount:
				result = "ConsecutiveKillCount";
				break;
			case ESurvivorsRougeSystemVarType.GoldGainEfficiency:
				result = "GoldGainEfficiency";
				break;
			case ESurvivorsRougeSystemVarType.LoopCountOfBatch:
				result = "LoopCountOfBatch";
				break;
			case ESurvivorsRougeSystemVarType.CurLoopOfCurBatch:
				result = "CurLoopOfCurBatch";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x060071B0 RID: 29104 RVA: 0x0010FAE0 File Offset: 0x0010DCE0
		public static ESurvivorsRougeSystemVarType FromString(string name)
		{
			ESurvivorsRougeSystemVarType result;
			if (!ESurvivorsRougeSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESurvivorsRougeSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060071B1 RID: 29105 RVA: 0x0010FB0C File Offset: 0x0010DD0C
		public static bool TryFromString(string name, out ESurvivorsRougeSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ESurvivorsRougeSystemVarType.Gold;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				switch (length)
				{
				case 4:
					if (name == "Gold")
					{
						value = ESurvivorsRougeSystemVarType.Gold;
						return true;
					}
					break;
				case 5:
					if (name == "Batch")
					{
						value = ESurvivorsRougeSystemVarType.Batch;
						return true;
					}
					break;
				case 6:
				case 7:
					break;
				case 8:
					if (name == "MaxBatch")
					{
						value = ESurvivorsRougeSystemVarType.MaxBatch;
						return true;
					}
					break;
				default:
					switch (length)
					{
					case 16:
					{
						char c = name[0];
						if (c != 'L')
						{
							if (c == 'T')
							{
								if (name == "TreasureBoxCount")
								{
									value = ESurvivorsRougeSystemVarType.TreasureBoxCount;
									return true;
								}
							}
						}
						else if (name == "LoopCountOfBatch")
						{
							value = ESurvivorsRougeSystemVarType.LoopCountOfBatch;
							return true;
						}
						break;
					}
					case 17:
					{
						char c = name[0];
						if (c != 'C')
						{
							if (c == 'E')
							{
								if (name == "EndlessBatchLimit")
								{
									value = ESurvivorsRougeSystemVarType.EndlessBatchLimit;
									return true;
								}
							}
						}
						else if (name == "CurLoopOfCurBatch")
						{
							value = ESurvivorsRougeSystemVarType.CurLoopOfCurBatch;
							return true;
						}
						break;
					}
					case 18:
						if (name == "GoldGainEfficiency")
						{
							value = ESurvivorsRougeSystemVarType.GoldGainEfficiency;
							return true;
						}
						break;
					case 20:
						if (name == "ConsecutiveKillCount")
						{
							value = ESurvivorsRougeSystemVarType.ConsecutiveKillCount;
							return true;
						}
						break;
					}
					break;
				}
			}
			value = ESurvivorsRougeSystemVarType.Gold;
			return false;
		}

		// Token: 0x060071B2 RID: 29106 RVA: 0x0010FC64 File Offset: 0x0010DE64
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Gold",
				"Batch",
				"MaxBatch",
				"EndlessBatchLimit",
				"TreasureBoxCount",
				"ConsecutiveKillCount",
				"GoldGainEfficiency",
				"LoopCountOfBatch",
				"CurLoopOfCurBatch"
			};
		}

		// Token: 0x060071B3 RID: 29107 RVA: 0x0010FCC0 File Offset: 0x0010DEC0
		public static ESurvivorsRougeSystemVarType[] GetValues()
		{
			return new ESurvivorsRougeSystemVarType[]
			{
				ESurvivorsRougeSystemVarType.Gold,
				ESurvivorsRougeSystemVarType.Batch,
				ESurvivorsRougeSystemVarType.MaxBatch,
				ESurvivorsRougeSystemVarType.EndlessBatchLimit,
				ESurvivorsRougeSystemVarType.TreasureBoxCount,
				ESurvivorsRougeSystemVarType.ConsecutiveKillCount,
				ESurvivorsRougeSystemVarType.GoldGainEfficiency,
				ESurvivorsRougeSystemVarType.LoopCountOfBatch,
				ESurvivorsRougeSystemVarType.CurLoopOfCurBatch
			};
		}

		// Token: 0x060071B4 RID: 29108 RVA: 0x0010FCD4 File Offset: 0x0010DED4
		public static string[] GetNames()
		{
			return new string[]
			{
				"Gold",
				"Batch",
				"MaxBatch",
				"EndlessBatchLimit",
				"TreasureBoxCount",
				"ConsecutiveKillCount",
				"GoldGainEfficiency",
				"LoopCountOfBatch",
				"CurLoopOfCurBatch"
			};
		}
	}
}
