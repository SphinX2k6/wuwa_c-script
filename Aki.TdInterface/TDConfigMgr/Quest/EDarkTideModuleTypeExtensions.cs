using System;

namespace Aki.TDConfigMgr.Quest
{
	// Token: 0x02001374 RID: 4980
	public static class EDarkTideModuleTypeExtensions
	{
		// Token: 0x06006FE4 RID: 28644 RVA: 0x0010A7F0 File Offset: 0x001089F0
		public static string ToEnumString(this EDarkTideModuleType value)
		{
			string result;
			if (value == EDarkTideModuleType.BossEvent)
			{
				result = "BossEvent";
			}
			else
			{
				result = value.ToString();
			}
			return result;
		}

		// Token: 0x06006FE5 RID: 28645 RVA: 0x0010A818 File Offset: 0x00108A18
		public static EDarkTideModuleType FromString(string name)
		{
			EDarkTideModuleType result;
			if (!EDarkTideModuleTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EDarkTideModuleType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x06006FE6 RID: 28646 RVA: 0x0010A841 File Offset: 0x00108A41
		public static bool TryFromString(string name, out EDarkTideModuleType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EDarkTideModuleType.BossEvent;
				return false;
			}
			if (name == "BossEvent")
			{
				value = EDarkTideModuleType.BossEvent;
				return true;
			}
			value = EDarkTideModuleType.BossEvent;
			return false;
		}

		// Token: 0x06006FE7 RID: 28647 RVA: 0x0010A866 File Offset: 0x00108A66
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"BossEvent"
			};
		}

		// Token: 0x06006FE8 RID: 28648 RVA: 0x0010A876 File Offset: 0x00108A76
		public static EDarkTideModuleType[] GetValues()
		{
			return new EDarkTideModuleType[1];
		}

		// Token: 0x06006FE9 RID: 28649 RVA: 0x0010A87E File Offset: 0x00108A7E
		public static string[] GetNames()
		{
			return new string[]
			{
				"BossEvent"
			};
		}
	}
}
