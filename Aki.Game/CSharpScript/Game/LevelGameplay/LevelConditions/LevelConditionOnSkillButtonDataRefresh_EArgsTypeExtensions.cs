using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02005F20 RID: 24352
	public static class LevelConditionOnSkillButtonDataRefresh_EArgsTypeExtensions
	{
		// Token: 0x0603A962 RID: 239970 RVA: 0x0108ED10 File Offset: 0x0108CF10
		public static string ToEnumString(this LevelConditionOnSkillButtonDataRefresh.EArgsType value)
		{
			string result;
			if (value == LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType)
			{
				result = "skillId";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x0603A963 RID: 239971 RVA: 0x0108ED38 File Offset: 0x0108CF38
		public static LevelConditionOnSkillButtonDataRefresh.EArgsType FromString(string name)
		{
			LevelConditionOnSkillButtonDataRefresh.EArgsType result;
			if (!LevelConditionOnSkillButtonDataRefresh_EArgsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 LevelConditionOnSkillButtonDataRefresh.EArgsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0603A964 RID: 239972 RVA: 0x0108ED61 File Offset: 0x0108CF61
		public static bool TryFromString(string name, out LevelConditionOnSkillButtonDataRefresh.EArgsType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType;
				return false;
			}
			if (name == "skillId")
			{
				value = LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType;
				return true;
			}
			value = LevelConditionOnSkillButtonDataRefresh.EArgsType.ActionType;
			return false;
		}

		// Token: 0x0603A965 RID: 239973 RVA: 0x0108ED86 File Offset: 0x0108CF86
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"skillId"
			};
		}

		// Token: 0x0603A966 RID: 239974 RVA: 0x0108ED96 File Offset: 0x0108CF96
		public static LevelConditionOnSkillButtonDataRefresh.EArgsType[] GetValues()
		{
			return new LevelConditionOnSkillButtonDataRefresh.EArgsType[1];
		}

		// Token: 0x0603A967 RID: 239975 RVA: 0x0108ED9E File Offset: 0x0108CF9E
		public static string[] GetNames()
		{
			return new string[]
			{
				"ActionType"
			};
		}
	}
}
