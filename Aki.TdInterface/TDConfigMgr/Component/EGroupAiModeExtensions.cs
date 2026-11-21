using System;

namespace Aki.TDConfigMgr.Component
{
	// Token: 0x02000A0F RID: 2575
	public static class EGroupAiModeExtensions
	{
		// Token: 0x06003956 RID: 14678 RVA: 0x00094228 File Offset: 0x00092428
		public static string ToEnumString(this EGroupAiMode value)
		{
			string result;
			switch (value)
			{
			case EGroupAiMode.Default:
				result = "Default";
				break;
			case EGroupAiMode.Patrol:
				result = "Patrol";
				break;
			case EGroupAiMode.MonsterEcology:
				result = "MonsterEcology";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06003957 RID: 14679 RVA: 0x00094270 File Offset: 0x00092470
		public static EGroupAiMode FromString(string name)
		{
			EGroupAiMode result;
			if (!EGroupAiModeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EGroupAiMode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06003958 RID: 14680 RVA: 0x0009429C File Offset: 0x0009249C
		public static bool TryFromString(string name, out EGroupAiMode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EGroupAiMode.Default;
				return false;
			}
			if (name == "Default")
			{
				value = EGroupAiMode.Default;
				return true;
			}
			if (name == "Patrol")
			{
				value = EGroupAiMode.Patrol;
				return true;
			}
			if (!(name == "MonsterEcology"))
			{
				value = EGroupAiMode.Default;
				return false;
			}
			value = EGroupAiMode.MonsterEcology;
			return true;
		}

		// Token: 0x06003959 RID: 14681 RVA: 0x000942F2 File Offset: 0x000924F2
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Default",
				"Patrol",
				"MonsterEcology"
			};
		}

		// Token: 0x0600395A RID: 14682 RVA: 0x00094312 File Offset: 0x00092512
		public static EGroupAiMode[] GetValues()
		{
			return new EGroupAiMode[]
			{
				EGroupAiMode.Default,
				EGroupAiMode.Patrol,
				EGroupAiMode.MonsterEcology
			};
		}

		// Token: 0x0600395B RID: 14683 RVA: 0x00094322 File Offset: 0x00092522
		public static string[] GetNames()
		{
			return new string[]
			{
				"Default",
				"Patrol",
				"MonsterEcology"
			};
		}
	}
}
