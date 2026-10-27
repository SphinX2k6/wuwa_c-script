using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001270 RID: 4720
	public static class EQuestScheduleTypeExtensions
	{
		// Token: 0x06006A9F RID: 27295 RVA: 0x000FF91C File Offset: 0x000FDB1C
		public static string ToEnumString(this EQuestScheduleType value)
		{
			string result;
			switch (value)
			{
			case EQuestScheduleType.None:
				result = "None";
				break;
			case EQuestScheduleType.ChildQuestCompleted:
				result = "ChildQuestCompleted";
				break;
			case EQuestScheduleType.EntityHP:
				result = "EntityHP";
				break;
			case EQuestScheduleType.Score:
				result = "Score";
				break;
			case EQuestScheduleType.ChildQuestCompletedCount:
				result = "ChildQuestCompletedCount";
				break;
			case EQuestScheduleType.TowerChallengeTitle:
				result = "TowerChallengeTitle";
				break;
			case EQuestScheduleType.RoleTowerChallengeTitle:
				result = "RoleTowerChallengeTitle";
				break;
			case EQuestScheduleType.Var:
				result = "Var";
				break;
			case EQuestScheduleType.MultiVar:
				result = "MultiVar";
				break;
			case EQuestScheduleType.TimeLeft:
				result = "TimeLeft";
				break;
			case EQuestScheduleType.Condition:
				result = "Condition";
				break;
			case EQuestScheduleType.ProgressValue:
				result = "ProgressValue";
				break;
			case EQuestScheduleType.DistanceValue:
				result = "DistanceValue";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06006AA0 RID: 27296 RVA: 0x000FF9DC File Offset: 0x000FDBDC
		public static EQuestScheduleType FromString(string name)
		{
			EQuestScheduleType result;
			if (!EQuestScheduleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestScheduleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006AA1 RID: 27297 RVA: 0x000FFA08 File Offset: 0x000FDC08
		public static bool TryFromString(string name, out EQuestScheduleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQuestScheduleType.None;
				return false;
			}
			if (name != null)
			{
				int length = name.Length;
				if (length <= 19)
				{
					switch (length)
					{
					case 3:
						if (name == "Var")
						{
							value = EQuestScheduleType.Var;
							return true;
						}
						break;
					case 4:
						if (name == "None")
						{
							value = EQuestScheduleType.None;
							return true;
						}
						break;
					case 5:
						if (name == "Score")
						{
							value = EQuestScheduleType.Score;
							return true;
						}
						break;
					case 6:
					case 7:
					case 10:
					case 11:
					case 12:
						break;
					case 8:
					{
						char c = name[0];
						if (c != 'E')
						{
							if (c != 'M')
							{
								if (c == 'T')
								{
									if (name == "TimeLeft")
									{
										value = EQuestScheduleType.TimeLeft;
										return true;
									}
								}
							}
							else if (name == "MultiVar")
							{
								value = EQuestScheduleType.MultiVar;
								return true;
							}
						}
						else if (name == "EntityHP")
						{
							value = EQuestScheduleType.EntityHP;
							return true;
						}
						break;
					}
					case 9:
						if (name == "Condition")
						{
							value = EQuestScheduleType.Condition;
							return true;
						}
						break;
					case 13:
					{
						char c = name[0];
						if (c != 'D')
						{
							if (c == 'P')
							{
								if (name == "ProgressValue")
								{
									value = EQuestScheduleType.ProgressValue;
									return true;
								}
							}
						}
						else if (name == "DistanceValue")
						{
							value = EQuestScheduleType.DistanceValue;
							return true;
						}
						break;
					}
					default:
						if (length == 19)
						{
							char c = name[0];
							if (c != 'C')
							{
								if (c == 'T')
								{
									if (name == "TowerChallengeTitle")
									{
										value = EQuestScheduleType.TowerChallengeTitle;
										return true;
									}
								}
							}
							else if (name == "ChildQuestCompleted")
							{
								value = EQuestScheduleType.ChildQuestCompleted;
								return true;
							}
						}
						break;
					}
				}
				else if (length != 23)
				{
					if (length == 24)
					{
						if (name == "ChildQuestCompletedCount")
						{
							value = EQuestScheduleType.ChildQuestCompletedCount;
							return true;
						}
					}
				}
				else if (name == "RoleTowerChallengeTitle")
				{
					value = EQuestScheduleType.RoleTowerChallengeTitle;
					return true;
				}
			}
			value = EQuestScheduleType.None;
			return false;
		}

		// Token: 0x06006AA2 RID: 27298 RVA: 0x000FFC14 File Offset: 0x000FDE14
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"None",
				"ChildQuestCompleted",
				"EntityHP",
				"Score",
				"ChildQuestCompletedCount",
				"TowerChallengeTitle",
				"RoleTowerChallengeTitle",
				"Var",
				"MultiVar",
				"TimeLeft",
				"Condition",
				"ProgressValue",
				"DistanceValue"
			};
		}

		// Token: 0x06006AA3 RID: 27299 RVA: 0x000FFC94 File Offset: 0x000FDE94
		public static EQuestScheduleType[] GetValues()
		{
			return new EQuestScheduleType[]
			{
				EQuestScheduleType.None,
				EQuestScheduleType.ChildQuestCompleted,
				EQuestScheduleType.EntityHP,
				EQuestScheduleType.Score,
				EQuestScheduleType.ChildQuestCompletedCount,
				EQuestScheduleType.TowerChallengeTitle,
				EQuestScheduleType.RoleTowerChallengeTitle,
				EQuestScheduleType.Var,
				EQuestScheduleType.MultiVar,
				EQuestScheduleType.TimeLeft,
				EQuestScheduleType.Condition,
				EQuestScheduleType.ProgressValue,
				EQuestScheduleType.DistanceValue
			};
		}

		// Token: 0x06006AA4 RID: 27300 RVA: 0x000FFCA8 File Offset: 0x000FDEA8
		public static string[] GetNames()
		{
			return new string[]
			{
				"None",
				"ChildQuestCompleted",
				"EntityHP",
				"Score",
				"ChildQuestCompletedCount",
				"TowerChallengeTitle",
				"RoleTowerChallengeTitle",
				"Var",
				"MultiVar",
				"TimeLeft",
				"Condition",
				"ProgressValue",
				"DistanceValue"
			};
		}
	}
}
