using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F8 RID: 5112
	public static class ETrapDefenseSystemVarTypeExtensions
	{
		// Token: 0x06007236 RID: 29238 RVA: 0x00111508 File Offset: 0x0010F708
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

		// Token: 0x06007237 RID: 29239 RVA: 0x00111598 File Offset: 0x0010F798
		public static ETrapDefenseSystemVarType FromString(string name)
		{
			ETrapDefenseSystemVarType result;
			if (!ETrapDefenseSystemVarTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefenseSystemVarType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007238 RID: 29240 RVA: 0x001115C4 File Offset: 0x0010F7C4
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

		// Token: 0x06007239 RID: 29241 RVA: 0x001116F0 File Offset: 0x0010F8F0
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

		// Token: 0x0600723A RID: 29242 RVA: 0x0011174C File Offset: 0x0010F94C
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

		// Token: 0x0600723B RID: 29243 RVA: 0x00111760 File Offset: 0x0010F960
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
