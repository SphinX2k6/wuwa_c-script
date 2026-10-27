using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020023E3 RID: 9187
	public static class EQuestCommonTipTypeExtensions
	{
		// Token: 0x0600C7FC RID: 51196 RVA: 0x001D4670 File Offset: 0x001D2870
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

		// Token: 0x0600C7FD RID: 51197 RVA: 0x001D46E8 File Offset: 0x001D28E8
		public static EQuestCommonTipType FromString(string name)
		{
			EQuestCommonTipType result;
			if (!EQuestCommonTipTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EQuestCommonTipType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600C7FE RID: 51198 RVA: 0x001D4714 File Offset: 0x001D2914
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

		// Token: 0x0600C7FF RID: 51199 RVA: 0x001D481E File Offset: 0x001D2A1E
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

		// Token: 0x0600C800 RID: 51200 RVA: 0x001D485E File Offset: 0x001D2A5E
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

		// Token: 0x0600C801 RID: 51201 RVA: 0x001D4871 File Offset: 0x001D2A71
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
