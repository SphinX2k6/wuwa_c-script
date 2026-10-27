using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002485 RID: 9349
	public static class ETrapDefensePlayerOperationTypeExtensions
	{
		// Token: 0x0600CAD5 RID: 51925 RVA: 0x001DDAAC File Offset: 0x001DBCAC
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

		// Token: 0x0600CAD6 RID: 51926 RVA: 0x001DDAF4 File Offset: 0x001DBCF4
		public static ETrapDefensePlayerOperationType FromString(string name)
		{
			ETrapDefensePlayerOperationType result;
			if (!ETrapDefensePlayerOperationTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ETrapDefensePlayerOperationType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CAD7 RID: 51927 RVA: 0x001DDB20 File Offset: 0x001DBD20
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

		// Token: 0x0600CAD8 RID: 51928 RVA: 0x001DDB76 File Offset: 0x001DBD76
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SpawnMonster",
				"ConstructTrap",
				"RecycleTrap"
			};
		}

		// Token: 0x0600CAD9 RID: 51929 RVA: 0x001DDB96 File Offset: 0x001DBD96
		public static ETrapDefensePlayerOperationType[] GetValues()
		{
			return new ETrapDefensePlayerOperationType[]
			{
				ETrapDefensePlayerOperationType.SpawnMonster,
				ETrapDefensePlayerOperationType.ConstructTrap,
				ETrapDefensePlayerOperationType.RecycleTrap
			};
		}

		// Token: 0x0600CADA RID: 51930 RVA: 0x001DDBA6 File Offset: 0x001DBDA6
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
