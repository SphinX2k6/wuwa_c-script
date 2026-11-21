using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001398 RID: 5016
	public static class EMotorFightSystemVarExtensions
	{
		// Token: 0x06007086 RID: 28806 RVA: 0x0010C5A8 File Offset: 0x0010A7A8
		public static string ToEnumString(this EMotorFightSystemVar value)
		{
			string result;
			switch (value)
			{
			case EMotorFightSystemVar.LevelProgress:
				result = "LevelProgress";
				break;
			case EMotorFightSystemVar.SubLevel:
				result = "SubLevel";
				break;
			case EMotorFightSystemVar.OpenCollectionSelectViewCount:
				result = "OpenCollectionSelectViewCount";
				break;
			case EMotorFightSystemVar.SpawnEliteCount:
				result = "SpawnEliteCount";
				break;
			case EMotorFightSystemVar.SpawnBossCount:
				result = "SpawnBossCount";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007087 RID: 28807 RVA: 0x0010C608 File Offset: 0x0010A808
		public static EMotorFightSystemVar FromString(string name)
		{
			EMotorFightSystemVar result;
			if (!EMotorFightSystemVarExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorFightSystemVar 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007088 RID: 28808 RVA: 0x0010C634 File Offset: 0x0010A834
		public static bool TryFromString(string name, out EMotorFightSystemVar value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EMotorFightSystemVar.LevelProgress;
				return false;
			}
			if (name == "LevelProgress")
			{
				value = EMotorFightSystemVar.LevelProgress;
				return true;
			}
			if (name == "SubLevel")
			{
				value = EMotorFightSystemVar.SubLevel;
				return true;
			}
			if (name == "OpenCollectionSelectViewCount")
			{
				value = EMotorFightSystemVar.OpenCollectionSelectViewCount;
				return true;
			}
			if (name == "SpawnEliteCount")
			{
				value = EMotorFightSystemVar.SpawnEliteCount;
				return true;
			}
			if (!(name == "SpawnBossCount"))
			{
				value = EMotorFightSystemVar.LevelProgress;
				return false;
			}
			value = EMotorFightSystemVar.SpawnBossCount;
			return true;
		}

		// Token: 0x06007089 RID: 28809 RVA: 0x0010C6AE File Offset: 0x0010A8AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"LevelProgress",
				"SubLevel",
				"OpenCollectionSelectViewCount",
				"SpawnEliteCount",
				"SpawnBossCount"
			};
		}

		// Token: 0x0600708A RID: 28810 RVA: 0x0010C6DE File Offset: 0x0010A8DE
		public static EMotorFightSystemVar[] GetValues()
		{
			return new EMotorFightSystemVar[]
			{
				EMotorFightSystemVar.LevelProgress,
				EMotorFightSystemVar.SubLevel,
				EMotorFightSystemVar.OpenCollectionSelectViewCount,
				EMotorFightSystemVar.SpawnEliteCount,
				EMotorFightSystemVar.SpawnBossCount
			};
		}

		// Token: 0x0600708B RID: 28811 RVA: 0x0010C6F1 File Offset: 0x0010A8F1
		public static string[] GetNames()
		{
			return new string[]
			{
				"LevelProgress",
				"SubLevel",
				"OpenCollectionSelectViewCount",
				"SpawnEliteCount",
				"SpawnBossCount"
			};
		}
	}
}
