using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x0200122A RID: 4650
	public static class EBtNodeExtensions
	{
		// Token: 0x06006964 RID: 26980 RVA: 0x000FB10C File Offset: 0x000F930C
		public static string ToEnumString(this EBtNode value)
		{
			string result;
			switch (value)
			{
			case EBtNode.Start:
				result = "Start";
				break;
			case EBtNode.QuestSucceed:
				result = "QuestSucceed";
				break;
			case EBtNode.QuestFailed:
				result = "QuestFailed";
				break;
			case EBtNode.AlwaysTrue:
				result = "AlwaysTrue";
				break;
			case EBtNode.AlwaysFalse:
				result = "AlwaysFalse";
				break;
			case EBtNode.Repeater:
				result = "Repeater";
				break;
			case EBtNode.Sequence:
				result = "Sequence";
				break;
			case EBtNode.Select:
				result = "Select";
				break;
			case EBtNode.ParallelSelect:
				result = "ParallelSelect";
				break;
			case EBtNode.Condition:
				result = "Condition";
				break;
			case EBtNode.ConditionSelector:
				result = "ConditionSelector";
				break;
			case EBtNode.ChildQuest:
				result = "ChildQuest";
				break;
			case EBtNode.Action:
				result = "Action";
				break;
			case EBtNode.ActionWithResult:
				result = "ActionWithResult";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006965 RID: 26981 RVA: 0x000FB1D8 File Offset: 0x000F93D8
		public static EBtNode FromString(string name)
		{
			EBtNode result;
			if (!EBtNodeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EBtNode 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006966 RID: 26982 RVA: 0x000FB204 File Offset: 0x000F9404
		public static bool TryFromString(string name, out EBtNode value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EBtNode.Start;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 5:
					if (name == "Start")
					{
						value = EBtNode.Start;
						return true;
					}
					break;
				case 6:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'S')
						{
							if (name == "Select")
							{
								value = EBtNode.Select;
								return true;
							}
						}
					}
					else if (name == "Action")
					{
						value = EBtNode.Action;
						return true;
					}
					break;
				}
				case 8:
				{
					char c = name[0];
					if (c != 'R')
					{
						if (c == 'S')
						{
							if (name == "Sequence")
							{
								value = EBtNode.Sequence;
								return true;
							}
						}
					}
					else if (name == "Repeater")
					{
						value = EBtNode.Repeater;
						return true;
					}
					break;
				}
				case 9:
					if (name == "Condition")
					{
						value = EBtNode.Condition;
						return true;
					}
					break;
				case 10:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'C')
						{
							if (name == "ChildQuest")
							{
								value = EBtNode.ChildQuest;
								return true;
							}
						}
					}
					else if (name == "AlwaysTrue")
					{
						value = EBtNode.AlwaysTrue;
						return true;
					}
					break;
				}
				case 11:
				{
					char c = name[0];
					if (c != 'A')
					{
						if (c == 'Q')
						{
							if (name == "QuestFailed")
							{
								value = EBtNode.QuestFailed;
								return true;
							}
						}
					}
					else if (name == "AlwaysFalse")
					{
						value = EBtNode.AlwaysFalse;
						return true;
					}
					break;
				}
				case 12:
					if (name == "QuestSucceed")
					{
						value = EBtNode.QuestSucceed;
						return true;
					}
					break;
				case 14:
					if (name == "ParallelSelect")
					{
						value = EBtNode.ParallelSelect;
						return true;
					}
					break;
				case 16:
					if (name == "ActionWithResult")
					{
						value = EBtNode.ActionWithResult;
						return true;
					}
					break;
				case 17:
					if (name == "ConditionSelector")
					{
						value = EBtNode.ConditionSelector;
						return true;
					}
					break;
				}
			}
			value = EBtNode.Start;
			return false;
		}

		// Token: 0x06006967 RID: 26983 RVA: 0x000FB43C File Offset: 0x000F963C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Start",
				"QuestSucceed",
				"QuestFailed",
				"AlwaysTrue",
				"AlwaysFalse",
				"Repeater",
				"Sequence",
				"Select",
				"ParallelSelect",
				"Condition",
				"ConditionSelector",
				"ChildQuest",
				"Action",
				"ActionWithResult"
			};
		}

		// Token: 0x06006968 RID: 26984 RVA: 0x000FB4C5 File Offset: 0x000F96C5
		public static EBtNode[] GetValues()
		{
			return new EBtNode[]
			{
				EBtNode.Start,
				EBtNode.QuestSucceed,
				EBtNode.QuestFailed,
				EBtNode.AlwaysTrue,
				EBtNode.AlwaysFalse,
				EBtNode.Repeater,
				EBtNode.Sequence,
				EBtNode.Select,
				EBtNode.ParallelSelect,
				EBtNode.Condition,
				EBtNode.ConditionSelector,
				EBtNode.ChildQuest,
				EBtNode.Action,
				EBtNode.ActionWithResult
			};
		}

		// Token: 0x06006969 RID: 26985 RVA: 0x000FB4DC File Offset: 0x000F96DC
		public static string[] GetNames()
		{
			return new string[]
			{
				"Start",
				"QuestSucceed",
				"QuestFailed",
				"AlwaysTrue",
				"AlwaysFalse",
				"Repeater",
				"Sequence",
				"Select",
				"ParallelSelect",
				"Condition",
				"ConditionSelector",
				"ChildQuest",
				"Action",
				"ActionWithResult"
			};
		}
	}
}
