using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013B2 RID: 5042
	public static class EQuestScheduleUiTypeExtensions
	{
		// Token: 0x060070FB RID: 28923 RVA: 0x0010D990 File Offset: 0x0010BB90
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

		// Token: 0x060070FC RID: 28924 RVA: 0x0010D9C8 File Offset: 0x0010BBC8
		public static EQuestScheduleUiType FromString(string name)
		{
			EQuestScheduleUiType result;
			if (!EQuestScheduleUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestScheduleUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x060070FD RID: 28925 RVA: 0x0010D9F1 File Offset: 0x0010BBF1
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

		// Token: 0x060070FE RID: 28926 RVA: 0x0010DA2A File Offset: 0x0010BC2A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Task",
				"LevelPlay"
			};
		}

		// Token: 0x060070FF RID: 28927 RVA: 0x0010DA42 File Offset: 0x0010BC42
		public static EQuestScheduleUiType[] GetValues()
		{
			return new EQuestScheduleUiType[]
			{
				EQuestScheduleUiType.Task,
				EQuestScheduleUiType.LevelPlay
			};
		}

		// Token: 0x06007100 RID: 28928 RVA: 0x0010DA4E File Offset: 0x0010BC4E
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
