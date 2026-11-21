using System;

namespace CSharpScript.Game.Module.ActivityCommonRootView
{
	// Token: 0x02005A8F RID: 23183
	public static class ECommonChildViewNameExtensions
	{
		// Token: 0x0603923F RID: 234047 RVA: 0x01000C38 File Offset: 0x00FFEE38
		public static string ToEnumString(this ECommonChildViewName value)
		{
			string result;
			switch (value)
			{
			case ECommonChildViewName.SolarSchoolMain:
				result = "SolarSchoolMain";
				break;
			case ECommonChildViewName.SolarSchoolLocation:
				result = "SolarSchoolLocation";
				break;
			case ECommonChildViewName.SolarSchoolVisualNovel:
				result = "SolarSchoolVisualNovel";
				break;
			case ECommonChildViewName.SolarSchoolMap:
				result = "SolarSchoolMap";
				break;
			case ECommonChildViewName.SolarSchoolQuest:
				result = "SolarSchoolQuest";
				break;
			case ECommonChildViewName.SolarSchoolBehaviorExecute:
				result = "SolarSchoolBehaviorExecute";
				break;
			default:
				result = value.ToString();
				break;
			}
			return result;
		}

		// Token: 0x06039240 RID: 234048 RVA: 0x01000CA4 File Offset: 0x00FFEEA4
		public static ECommonChildViewName FromString(string name)
		{
			ECommonChildViewName result;
			if (!ECommonChildViewNameExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 ECommonChildViewName 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06039241 RID: 234049 RVA: 0x01000CD0 File Offset: 0x00FFEED0
		public static bool TryFromString(string name, out ECommonChildViewName value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = ECommonChildViewName.SolarSchoolMain;
				return false;
			}
			if (name == "SolarSchoolMain")
			{
				value = ECommonChildViewName.SolarSchoolMain;
				return true;
			}
			if (name == "SolarSchoolLocation")
			{
				value = ECommonChildViewName.SolarSchoolLocation;
				return true;
			}
			if (name == "SolarSchoolVisualNovel")
			{
				value = ECommonChildViewName.SolarSchoolVisualNovel;
				return true;
			}
			if (name == "SolarSchoolMap")
			{
				value = ECommonChildViewName.SolarSchoolMap;
				return true;
			}
			if (name == "SolarSchoolQuest")
			{
				value = ECommonChildViewName.SolarSchoolQuest;
				return true;
			}
			if (!(name == "SolarSchoolBehaviorExecute"))
			{
				value = ECommonChildViewName.SolarSchoolMain;
				return false;
			}
			value = ECommonChildViewName.SolarSchoolBehaviorExecute;
			return true;
		}

		// Token: 0x06039242 RID: 234050 RVA: 0x01000D5C File Offset: 0x00FFEF5C
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"SolarSchoolMain",
				"SolarSchoolLocation",
				"SolarSchoolVisualNovel",
				"SolarSchoolMap",
				"SolarSchoolQuest",
				"SolarSchoolBehaviorExecute"
			};
		}

		// Token: 0x06039243 RID: 234051 RVA: 0x01000D94 File Offset: 0x00FFEF94
		public static ECommonChildViewName[] GetValues()
		{
			return new ECommonChildViewName[]
			{
				ECommonChildViewName.SolarSchoolMain,
				ECommonChildViewName.SolarSchoolLocation,
				ECommonChildViewName.SolarSchoolVisualNovel,
				ECommonChildViewName.SolarSchoolMap,
				ECommonChildViewName.SolarSchoolQuest,
				ECommonChildViewName.SolarSchoolBehaviorExecute
			};
		}

		// Token: 0x06039244 RID: 234052 RVA: 0x01000DA7 File Offset: 0x00FFEFA7
		public static string[] GetNames()
		{
			return new string[]
			{
				"SolarSchoolMain",
				"SolarSchoolLocation",
				"SolarSchoolVisualNovel",
				"SolarSchoolMap",
				"SolarSchoolQuest",
				"SolarSchoolBehaviorExecute"
			};
		}
	}
}
