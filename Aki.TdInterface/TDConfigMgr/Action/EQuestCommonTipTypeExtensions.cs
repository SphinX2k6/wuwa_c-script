using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x0200267A RID: 9850
	public static class EQuestCommonTipTypeExtensions
	{
		// Token: 0x0600D47F RID: 54399 RVA: 0x001EDE1C File Offset: 0x001EC01C
		public static string ToEnumString(this EQuestCommonTipType value)
		{
			string result;
			switch (value)
			{
			case EQuestCommonTipType.Branch:
				result = "Branch";
				break;
			case EQuestCommonTipType.Role:
				result = "Role";
				break;
			case EQuestCommonTipType.Guide:
				result = "Guide";
				break;
			case EQuestCommonTipType.POI:
				result = "POI";
				break;
			case EQuestCommonTipType.Activity:
				result = "Activity";
				break;
			case EQuestCommonTipType.Daily:
				result = "Daily";
				break;
			case EQuestCommonTipType.Tale:
				result = "Tale";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x0600D480 RID: 54400 RVA: 0x001EDE94 File Offset: 0x001EC094
		public static EQuestCommonTipType FromString(string name)
		{
			EQuestCommonTipType result;
			if (!EQuestCommonTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestCommonTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D481 RID: 54401 RVA: 0x001EDEC0 File Offset: 0x001EC0C0
		public static bool TryFromString(string name, out EQuestCommonTipType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EQuestCommonTipType.Branch;
				return false;
			}
			if (name != null)
			{
				switch (name.Length)
				{
				case 3:
					if (name == "POI")
					{
						value = EQuestCommonTipType.POI;
						return true;
					}
					break;
				case 4:
				{
					char c = name[0];
					if (c != 'R')
					{
						if (c == 'T')
						{
							if (name == "Tale")
							{
								value = EQuestCommonTipType.Tale;
								return true;
							}
						}
					}
					else if (name == "Role")
					{
						value = EQuestCommonTipType.Role;
						return true;
					}
					break;
				}
				case 5:
				{
					char c = name[0];
					if (c != 'D')
					{
						if (c == 'G')
						{
							if (name == "Guide")
							{
								value = EQuestCommonTipType.Guide;
								return true;
							}
						}
					}
					else if (name == "Daily")
					{
						value = EQuestCommonTipType.Daily;
						return true;
					}
					break;
				}
				case 6:
					if (name == "Branch")
					{
						value = EQuestCommonTipType.Branch;
						return true;
					}
					break;
				case 8:
					if (name == "Activity")
					{
						value = EQuestCommonTipType.Activity;
						return true;
					}
					break;
				}
			}
			value = EQuestCommonTipType.Branch;
			return false;
		}

		// Token: 0x0600D482 RID: 54402 RVA: 0x001EDFCA File Offset: 0x001EC1CA
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Branch",
				"Role",
				"Guide",
				"POI",
				"Activity",
				"Daily",
				"Tale"
			};
		}

		// Token: 0x0600D483 RID: 54403 RVA: 0x001EE00A File Offset: 0x001EC20A
		public static EQuestCommonTipType[] GetValues()
		{
			return new EQuestCommonTipType[]
			{
				EQuestCommonTipType.Branch,
				EQuestCommonTipType.Role,
				EQuestCommonTipType.Guide,
				EQuestCommonTipType.POI,
				EQuestCommonTipType.Activity,
				EQuestCommonTipType.Daily,
				EQuestCommonTipType.Tale
			};
		}

		// Token: 0x0600D484 RID: 54404 RVA: 0x001EE01D File Offset: 0x001EC21D
		public static string[] GetNames()
		{
			return new string[]
			{
				"Branch",
				"Role",
				"Guide",
				"POI",
				"Activity",
				"Daily",
				"Tale"
			};
		}
	}
}
