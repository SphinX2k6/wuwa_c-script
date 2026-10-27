using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x020024B9 RID: 9401
	public static class EVisualNovelTransitionTypeExtensions
	{
		// Token: 0x0600CBBF RID: 52159 RVA: 0x001E0014 File Offset: 0x001DE214
		public static string ToEnumString(this EVisualNovelTransitionType value)
		{
			string result;
			if (value != EVisualNovelTransitionType.Location)
			{
				if (value != EVisualNovelTransitionType.Time)
				{
					result = value.ToString();
				}
				else
				{
					result = "Time";
				}
			}
			else
			{
				result = "Location";
			}
			return result;
		}

		// Token: 0x0600CBC0 RID: 52160 RVA: 0x001E004C File Offset: 0x001DE24C
		public static EVisualNovelTransitionType FromString(string name)
		{
			EVisualNovelTransitionType result;
			if (!EVisualNovelTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600CBC1 RID: 52161 RVA: 0x001E0075 File Offset: 0x001DE275
		public static bool TryFromString(string name, out EVisualNovelTransitionType value)
		{
			if (string.IsNullOrEmpty(name))
			{
				value = EVisualNovelTransitionType.Location;
				return false;
			}
			if (name == "Location")
			{
				value = EVisualNovelTransitionType.Location;
				return true;
			}
			if (!(name == "Time"))
			{
				value = EVisualNovelTransitionType.Location;
				return false;
			}
			value = EVisualNovelTransitionType.Time;
			return true;
		}

		// Token: 0x0600CBC2 RID: 52162 RVA: 0x001E00AE File Offset: 0x001DE2AE
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Location",
				"Time"
			};
		}

		// Token: 0x0600CBC3 RID: 52163 RVA: 0x001E00C6 File Offset: 0x001DE2C6
		public static EVisualNovelTransitionType[] GetValues()
		{
			return new EVisualNovelTransitionType[]
			{
				EVisualNovelTransitionType.Location,
				EVisualNovelTransitionType.Time
			};
		}

		// Token: 0x0600CBC4 RID: 52164 RVA: 0x001E00D2 File Offset: 0x001DE2D2
		public static string[] GetNames()
		{
			return new string[]
			{
				"Location",
				"Time"
			};
		}
	}
}
