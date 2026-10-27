using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020012B0 RID: 4784
	public static class ETrapDefenseConditionStepExtensions
	{
		// Token: 0x06006BBF RID: 27583 RVA: 0x00103388 File Offset: 0x00101588
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

		// Token: 0x06006BC0 RID: 27584 RVA: 0x001033E8 File Offset: 0x001015E8
		public static ETrapDefenseConditionStep FromString(string name)
		{
			ETrapDefenseConditionStep result;
			if (!ETrapDefenseConditionStepExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefenseConditionStep 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006BC1 RID: 27585 RVA: 0x00103414 File Offset: 0x00101614
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

		// Token: 0x06006BC2 RID: 27586 RVA: 0x0010348E File Offset: 0x0010168E
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

		// Token: 0x06006BC3 RID: 27587 RVA: 0x001034BE File Offset: 0x001016BE
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

		// Token: 0x06006BC4 RID: 27588 RVA: 0x001034D1 File Offset: 0x001016D1
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
