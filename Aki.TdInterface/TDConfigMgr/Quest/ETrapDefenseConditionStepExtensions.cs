using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013F6 RID: 5110
	public static class ETrapDefenseConditionStepExtensions
	{
		// Token: 0x0600722D RID: 29229 RVA: 0x00111350 File Offset: 0x0010F550
		public static string ToEnumString(this ETrapDefenseConditionStep value)
		{
			string result;
			switch (value)
			{
			case ETrapDefenseConditionStep.Reward:
				result = "Reward";
				break;
			case ETrapDefenseConditionStep.MapChange:
				result = "MapChange";
				break;
			case ETrapDefenseConditionStep.Preview:
				result = "Preview";
				break;
			case ETrapDefenseConditionStep.SpawnMonster:
				result = "SpawnMonster";
				break;
			case ETrapDefenseConditionStep.LoadAndRestoreMap:
				result = "LoadAndRestoreMap";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600722E RID: 29230 RVA: 0x001113B0 File Offset: 0x0010F5B0
		public static ETrapDefenseConditionStep FromString(string name)
		{
			ETrapDefenseConditionStep result;
			if (!ETrapDefenseConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefenseConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600722F RID: 29231 RVA: 0x001113DC File Offset: 0x0010F5DC
		public static bool TryFromString(string name, out ETrapDefenseConditionStep value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrapDefenseConditionStep.Reward;
				return false;
			}
			if (name == "Reward")
			{
				value = ETrapDefenseConditionStep.Reward;
				return true;
			}
			if (name == "MapChange")
			{
				value = ETrapDefenseConditionStep.MapChange;
				return true;
			}
			if (name == "Preview")
			{
				value = ETrapDefenseConditionStep.Preview;
				return true;
			}
			if (name == "SpawnMonster")
			{
				value = ETrapDefenseConditionStep.SpawnMonster;
				return true;
			}
			if (!(name == "LoadAndRestoreMap"))
			{
				value = ETrapDefenseConditionStep.Reward;
				return false;
			}
			value = ETrapDefenseConditionStep.LoadAndRestoreMap;
			return true;
		}

		// Token: 0x06007230 RID: 29232 RVA: 0x00111456 File Offset: 0x0010F656
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Reward",
				"MapChange",
				"Preview",
				"SpawnMonster",
				"LoadAndRestoreMap"
			};
		}

		// Token: 0x06007231 RID: 29233 RVA: 0x00111486 File Offset: 0x0010F686
		public static ETrapDefenseConditionStep[] GetValues()
		{
			return new ETrapDefenseConditionStep[]
			{
				ETrapDefenseConditionStep.Reward,
				ETrapDefenseConditionStep.MapChange,
				ETrapDefenseConditionStep.Preview,
				ETrapDefenseConditionStep.SpawnMonster,
				ETrapDefenseConditionStep.LoadAndRestoreMap
			};
		}

		// Token: 0x06007232 RID: 29234 RVA: 0x00111499 File Offset: 0x0010F699
		public static string[] GetNames()
		{
			return new string[]
			{
				"Reward",
				"MapChange",
				"Preview",
				"SpawnMonster",
				"LoadAndRestoreMap"
			};
		}
	}
}
