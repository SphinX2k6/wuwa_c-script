using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x020013CC RID: 5068
	public static class EShowUiTypeExtensions
	{
		// Token: 0x06007170 RID: 29040 RVA: 0x0010EBF8 File Offset: 0x0010CDF8
		public static string ToEnumString(this EShowUiType value)
		{
			string result;
			switch (value)
			{
			case EShowUiType.All:
				result = "All";
				break;
			case EShowUiType.RogueAbilitySelect:
				result = "RogueAbilitySelect";
				break;
			case EShowUiType.InformationView:
				result = "InformationView";
				break;
			case EShowUiType.RogueRandomEvent:
				result = "RogueRandomEvent";
				break;
			case EShowUiType.RoleTrialActivities:
				result = "RoleTrialActivities";
				break;
			case EShowUiType.RoleSkinTrialActivities:
				result = "RoleSkinTrialActivities";
				break;
			case EShowUiType.Cook:
				result = "Cook";
				break;
			case EShowUiType.Synthetic:
				result = "Synthetic";
				break;
			case EShowUiType.Forging:
				result = "Forging";
				break;
			case EShowUiType.MowBuffDistribute:
				result = "MowBuffDistribute";
				break;
			case EShowUiType.PermanentRogueUi:
				result = "PermanentRogueUi";
				break;
			case EShowUiType.CiacconaAvgBoard:
				result = "CiacconaAvgBoard";
				break;
			case EShowUiType.ItemObtain:
				result = "ItemObtain";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06007171 RID: 29041 RVA: 0x0010ECB8 File Offset: 0x0010CEB8
		public static EShowUiType FromString(string name)
		{
			EShowUiType result;
			if (!EShowUiTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EShowUiType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06007172 RID: 29042 RVA: 0x0010ECE4 File Offset: 0x0010CEE4
		public static bool TryFromString(string name, out EShowUiType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EShowUiType.All;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "All")
					{
						value = EShowUiType.All;
						return true;
					}
					break;
				case 4:
					if (name == "Cook")
					{
						value = EShowUiType.Cook;
						return true;
					}
					break;
				case 7:
					if (name == "Forging")
					{
						value = EShowUiType.Forging;
						return true;
					}
					break;
				case 9:
					if (name == "Synthetic")
					{
						value = EShowUiType.Synthetic;
						return true;
					}
					break;
				case 10:
					if (name == "ItemObtain")
					{
						value = EShowUiType.ItemObtain;
						return true;
					}
					break;
				case 15:
					if (name == "InformationView")
					{
						value = EShowUiType.InformationView;
						return true;
					}
					break;
				case 16:
				{
					char c = name[0];
					if (c != 'C')
					{
						if (c != 'P')
						{
							if (c == 'R')
							{
								if (name == "RogueRandomEvent")
								{
									value = EShowUiType.RogueRandomEvent;
									return true;
								}
							}
						}
						else if (name == "PermanentRogueUi")
						{
							value = EShowUiType.PermanentRogueUi;
							return true;
						}
					}
					else if (name == "CiacconaAvgBoard")
					{
						value = EShowUiType.CiacconaAvgBoard;
						return true;
					}
					break;
				}
				case 17:
					if (name == "MowBuffDistribute")
					{
						value = EShowUiType.MowBuffDistribute;
						return true;
					}
					break;
				case 18:
					if (name == "RogueAbilitySelect")
					{
						value = EShowUiType.RogueAbilitySelect;
						return true;
					}
					break;
				case 19:
					if (name == "RoleTrialActivities")
					{
						value = EShowUiType.RoleTrialActivities;
						return true;
					}
					break;
				case 23:
					if (name == "RoleSkinTrialActivities")
					{
						value = EShowUiType.RoleSkinTrialActivities;
						return true;
					}
					break;
				}
			}
			value = EShowUiType.All;
			return false;
		}

		// Token: 0x06007173 RID: 29043 RVA: 0x0010EEC4 File Offset: 0x0010D0C4
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"All",
				"RogueAbilitySelect",
				"InformationView",
				"RogueRandomEvent",
				"RoleTrialActivities",
				"RoleSkinTrialActivities",
				"Cook",
				"Synthetic",
				"Forging",
				"MowBuffDistribute",
				"PermanentRogueUi",
				"CiacconaAvgBoard",
				"ItemObtain"
			};
		}

		// Token: 0x06007174 RID: 29044 RVA: 0x0010EF44 File Offset: 0x0010D144
		public static EShowUiType[] GetValues()
		{
			return new EShowUiType[]
			{
				EShowUiType.All,
				EShowUiType.RogueAbilitySelect,
				EShowUiType.InformationView,
				EShowUiType.RogueRandomEvent,
				EShowUiType.RoleTrialActivities,
				EShowUiType.RoleSkinTrialActivities,
				EShowUiType.Cook,
				EShowUiType.Synthetic,
				EShowUiType.Forging,
				EShowUiType.MowBuffDistribute,
				EShowUiType.PermanentRogueUi,
				EShowUiType.CiacconaAvgBoard,
				EShowUiType.ItemObtain
			};
		}

		// Token: 0x06007175 RID: 29045 RVA: 0x0010EF58 File Offset: 0x0010D158
		public static string[] GetNames()
		{
			return new string[]
			{
				"All",
				"RogueAbilitySelect",
				"InformationView",
				"RogueRandomEvent",
				"RoleTrialActivities",
				"RoleSkinTrialActivities",
				"Cook",
				"Synthetic",
				"Forging",
				"MowBuffDistribute",
				"PermanentRogueUi",
				"CiacconaAvgBoard",
				"ItemObtain"
			};
		}
	}
}
