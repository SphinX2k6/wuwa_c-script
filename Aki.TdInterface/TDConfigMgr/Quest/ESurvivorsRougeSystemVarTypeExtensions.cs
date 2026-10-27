using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001298 RID: 4760
	public static class ESurvivorsRougeSystemVarTypeExtensions
	{
		// Token: 0x06006B53 RID: 27475 RVA: 0x00101C78 File Offset: 0x000FFE78
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

		// Token: 0x06006B54 RID: 27476 RVA: 0x00101D08 File Offset: 0x000FFF08
		public static ESurvivorsRougeSystemVarType FromString(string name)
		{
			ESurvivorsRougeSystemVarType result;
			if (!ESurvivorsRougeSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ESurvivorsRougeSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006B55 RID: 27477 RVA: 0x00101D34 File Offset: 0x000FFF34
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

		// Token: 0x06006B56 RID: 27478 RVA: 0x00101E8C File Offset: 0x0010008C
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

		// Token: 0x06006B57 RID: 27479 RVA: 0x00101EE8 File Offset: 0x001000E8
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

		// Token: 0x06006B58 RID: 27480 RVA: 0x00101EFC File Offset: 0x001000FC
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
