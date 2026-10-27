using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001272 RID: 4722
	public static class EQuestScheduleUiTypeExtensions
	{
		// Token: 0x06006AA8 RID: 27304 RVA: 0x000FFD64 File Offset: 0x000FDF64
		public static string ToEnumString(this EQuestScheduleUiType value)
		{
			string result;
			if (value != EQuestScheduleUiType.Task)
			{
				if (value != EQuestScheduleUiType.LevelPlay)
				{
					result = value.ToString();
				}
				else
				{
					result = "LevelPlay";
				}
			}
			else
			{
				result = "Task";
			}
			return result;
		}

		// Token: 0x06006AA9 RID: 27305 RVA: 0x000FFD9C File Offset: 0x000FDF9C
		public static EQuestScheduleUiType FromString(string name)
		{
			EQuestScheduleUiType result;
			if (!EQuestScheduleUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestScheduleUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AAA RID: 27306 RVA: 0x000FFDC5 File Offset: 0x000FDFC5
		public static bool TryFromString(string name, out EQuestScheduleUiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQuestScheduleUiType.Task;
				return false;
			}
			if (name == "Task")
			{
				value = EQuestScheduleUiType.Task;
				return true;
			}
			if (!(name == "LevelPlay"))
			{
				value = EQuestScheduleUiType.Task;
				return false;
			}
			value = EQuestScheduleUiType.LevelPlay;
			return true;
		}

		// Token: 0x06006AAB RID: 27307 RVA: 0x000FFDFE File Offset: 0x000FDFFE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Task",
				"LevelPlay"
			};
		}

		// Token: 0x06006AAC RID: 27308 RVA: 0x000FFE16 File Offset: 0x000FE016
		public static EQuestScheduleUiType[] GetValues()
		{
			return new EQuestScheduleUiType[]
			{
				EQuestScheduleUiType.Task,
				EQuestScheduleUiType.LevelPlay
			};
		}

		// Token: 0x06006AAD RID: 27309 RVA: 0x000FFE22 File Offset: 0x000FE022
		public static string[] GetNames()
		{
			return new string[]
			{
				"Task",
				"LevelPlay"
			};
		}
	}
}
