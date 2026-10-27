using System;

namespace CSharpScript.Game.LevelGamePlay.LevelConditions
{
	// Token: 0x02006DA1 RID: 28065
	public static class LevelConditionOnSkillButtonDataRefresh_EArgsTypeExtensions
	{
		// Token: 0x060447FE RID: 280574 RVA: 0x010E4AE8 File Offset: 0x010E2CE8
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

		// Token: 0x060447FF RID: 280575 RVA: 0x010E4B10 File Offset: 0x010E2D10
		public static LevelConditionOnSkillButtonDataRefresh.EArgsType FromString(string name)
		{
			LevelConditionOnSkillButtonDataRefresh.EArgsType result;
			if (!LevelConditionOnSkillButtonDataRefresh_EArgsTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 LevelConditionOnSkillButtonDataRefresh.EArgsType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06044800 RID: 280576 RVA: 0x010E4B39 File Offset: 0x010E2D39
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

		// Token: 0x06044801 RID: 280577 RVA: 0x010E4B5E File Offset: 0x010E2D5E
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"skillId"
			};
		}

		// Token: 0x06044802 RID: 280578 RVA: 0x010E4B6E File Offset: 0x010E2D6E
		public static LevelConditionOnSkillButtonDataRefresh.EArgsType[] GetValues()
		{
			return new LevelConditionOnSkillButtonDataRefresh.EArgsType[1];
		}

		// Token: 0x06044803 RID: 280579 RVA: 0x010E4B76 File Offset: 0x010E2D76
		public static string[] GetNames()
		{
			return new string[]
			{
				"ActionType"
			};
		}
	}
}
