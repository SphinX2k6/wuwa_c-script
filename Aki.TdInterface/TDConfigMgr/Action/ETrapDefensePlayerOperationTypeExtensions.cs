using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002728 RID: 10024
	public static class ETrapDefensePlayerOperationTypeExtensions
	{
		// Token: 0x0600D78E RID: 55182 RVA: 0x001F7C74 File Offset: 0x001F5E74
		public static string ToEnumString(this ETrapDefensePlayerOperationType value)
		{
			string result;
			switch (value)
			{
			case ETrapDefensePlayerOperationType.SpawnMonster:
				result = "SpawnMonster";
				break;
			case ETrapDefensePlayerOperationType.ConstructTrap:
				result = "ConstructTrap";
				break;
			case ETrapDefensePlayerOperationType.RecycleTrap:
				result = "RecycleTrap";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D78F RID: 55183 RVA: 0x001F7CBC File Offset: 0x001F5EBC
		public static ETrapDefensePlayerOperationType FromString(string name)
		{
			ETrapDefensePlayerOperationType result;
			if (!ETrapDefensePlayerOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefensePlayerOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D790 RID: 55184 RVA: 0x001F7CE8 File Offset: 0x001F5EE8
		public static bool TryFromString(string name, out ETrapDefensePlayerOperationType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ETrapDefensePlayerOperationType.SpawnMonster;
				return false;
			}
			if (name == "SpawnMonster")
			{
				value = ETrapDefensePlayerOperationType.SpawnMonster;
				return true;
			}
			if (name == "ConstructTrap")
			{
				value = ETrapDefensePlayerOperationType.ConstructTrap;
				return true;
			}
			if (!(name == "RecycleTrap"))
			{
				value = ETrapDefensePlayerOperationType.SpawnMonster;
				return false;
			}
			value = ETrapDefensePlayerOperationType.RecycleTrap;
			return true;
		}

		// Token: 0x0600D791 RID: 55185 RVA: 0x001F7D3E File Offset: 0x001F5F3E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpawnMonster",
				"ConstructTrap",
				"RecycleTrap"
			};
		}

		// Token: 0x0600D792 RID: 55186 RVA: 0x001F7D5E File Offset: 0x001F5F5E
		public static ETrapDefensePlayerOperationType[] GetValues()
		{
			return new ETrapDefensePlayerOperationType[]
			{
				ETrapDefensePlayerOperationType.SpawnMonster,
				ETrapDefensePlayerOperationType.ConstructTrap,
				ETrapDefensePlayerOperationType.RecycleTrap
			};
		}

		// Token: 0x0600D793 RID: 55187 RVA: 0x001F7D6E File Offset: 0x001F5F6E
		public static string[] GetNames()
		{
			return new string[]
			{
				"SpawnMonster",
				"ConstructTrap",
				"RecycleTrap"
			};
		}
	}
}
