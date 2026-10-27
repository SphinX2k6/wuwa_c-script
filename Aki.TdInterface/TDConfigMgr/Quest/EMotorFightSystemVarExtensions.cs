using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001258 RID: 4696
	public static class EMotorFightSystemVarExtensions
	{
		// Token: 0x06006A33 RID: 27187 RVA: 0x000FE97C File Offset: 0x000FCB7C
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

		// Token: 0x06006A34 RID: 27188 RVA: 0x000FE9DC File Offset: 0x000FCBDC
		public static EMotorFightSystemVar FromString(string name)
		{
			EMotorFightSystemVar result;
			if (!EMotorFightSystemVarExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EMotorFightSystemVar 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006A35 RID: 27189 RVA: 0x000FEA08 File Offset: 0x000FCC08
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

		// Token: 0x06006A36 RID: 27190 RVA: 0x000FEA82 File Offset: 0x000FCC82
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

		// Token: 0x06006A37 RID: 27191 RVA: 0x000FEAB2 File Offset: 0x000FCCB2
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

		// Token: 0x06006A38 RID: 27192 RVA: 0x000FEAC5 File Offset: 0x000FCCC5
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
