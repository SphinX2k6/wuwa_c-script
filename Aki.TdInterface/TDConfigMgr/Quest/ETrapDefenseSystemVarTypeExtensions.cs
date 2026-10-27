using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B2 RID: 4786
	public static class ETrapDefenseSystemVarTypeExtensions
	{
		// Token: 0x06006BC8 RID: 27592 RVA: 0x00103540 File Offset: 0x00101740
		public static string ToEnumString(this ETrapDefenseSystemVarType value)
		{
			string result;
			switch (value)
			{
			case ETrapDefenseSystemVarType.Health:
				result = "Health";
				break;
			case ETrapDefenseSystemVarType.Gold:
				result = "Gold";
				break;
			case ETrapDefenseSystemVarType.MaxBatch:
				result = "MaxBatch";
				break;
			case ETrapDefenseSystemVarType.Batch:
				result = "Batch";
				break;
			case ETrapDefenseSystemVarType.TrapCount:
				result = "TrapCount";
				break;
			case ETrapDefenseSystemVarType.MaxTrapCount:
				result = "MaxTrapCount";
				break;
			case ETrapDefenseSystemVarType.EnemyRemain:
				result = "EnemyRemain";
				break;
			case ETrapDefenseSystemVarType.MapChangeCount:
				result = "MapChangeCount";
				break;
			case ETrapDefenseSystemVarType.SpawnMonsterStepCompleteCount:
				result = "SpawnMonsterStepCompleteCount";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006BC9 RID: 27593 RVA: 0x001035D0 File Offset: 0x001017D0
		public static ETrapDefenseSystemVarType FromString(string name)
		{
			ETrapDefenseSystemVarType result;
			if (!ETrapDefenseSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefenseSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BCA RID: 27594 RVA: 0x001035FC File Offset: 0x001017FC
		public static bool TryFromString(string name, out ETrapDefenseSystemVarType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrapDefenseSystemVarType.Health;
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
						value = ETrapDefenseSystemVarType.Gold;
						return true;
					}
					break;
				case 5:
					if (name == "Batch")
					{
						value = ETrapDefenseSystemVarType.Batch;
						return true;
					}
					break;
				case 6:
					if (name == "Health")
					{
						value = ETrapDefenseSystemVarType.Health;
						return true;
					}
					break;
				case 7:
				case 10:
				case 13:
					break;
				case 8:
					if (name == "MaxBatch")
					{
						value = ETrapDefenseSystemVarType.MaxBatch;
						return true;
					}
					break;
				case 9:
					if (name == "TrapCount")
					{
						value = ETrapDefenseSystemVarType.TrapCount;
						return true;
					}
					break;
				case 11:
					if (name == "EnemyRemain")
					{
						value = ETrapDefenseSystemVarType.EnemyRemain;
						return true;
					}
					break;
				case 12:
					if (name == "MaxTrapCount")
					{
						value = ETrapDefenseSystemVarType.MaxTrapCount;
						return true;
					}
					break;
				case 14:
					if (name == "MapChangeCount")
					{
						value = ETrapDefenseSystemVarType.MapChangeCount;
						return true;
					}
					break;
				default:
					if (length == 29)
					{
						if (name == "SpawnMonsterStepCompleteCount")
						{
							value = ETrapDefenseSystemVarType.SpawnMonsterStepCompleteCount;
							return true;
						}
					}
					break;
				}
			}
			value = ETrapDefenseSystemVarType.Health;
			return false;
		}

		// Token: 0x06006BCB RID: 27595 RVA: 0x00103728 File Offset: 0x00101928
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Health",
				"Gold",
				"MaxBatch",
				"Batch",
				"TrapCount",
				"MaxTrapCount",
				"EnemyRemain",
				"MapChangeCount",
				"SpawnMonsterStepCompleteCount"
			};
		}

		// Token: 0x06006BCC RID: 27596 RVA: 0x00103784 File Offset: 0x00101984
		public static ETrapDefenseSystemVarType[] GetValues()
		{
			return new ETrapDefenseSystemVarType[]
			{
				ETrapDefenseSystemVarType.Health,
				ETrapDefenseSystemVarType.Gold,
				ETrapDefenseSystemVarType.MaxBatch,
				ETrapDefenseSystemVarType.Batch,
				ETrapDefenseSystemVarType.TrapCount,
				ETrapDefenseSystemVarType.MaxTrapCount,
				ETrapDefenseSystemVarType.EnemyRemain,
				ETrapDefenseSystemVarType.MapChangeCount,
				ETrapDefenseSystemVarType.SpawnMonsterStepCompleteCount
			};
		}

		// Token: 0x06006BCD RID: 27597 RVA: 0x00103798 File Offset: 0x00101998
		public static string[] GetNames()
		{
			return new string[]
			{
				"Health",
				"Gold",
				"MaxBatch",
				"Batch",
				"TrapCount",
				"MaxTrapCount",
				"EnemyRemain",
				"MapChangeCount",
				"SpawnMonsterStepCompleteCount"
			};
		}
	}
}
