using System;

namespace Aki.TDConfigMgr.Action
{
	// Token: 0x02002760 RID: 10080
	public static class EVisualNovelTransitionTypeExtensions
	{
		// Token: 0x0600D88A RID: 55434 RVA: 0x001FA400 File Offset: 0x001F8600
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

		// Token: 0x0600D88B RID: 55435 RVA: 0x001FA438 File Offset: 0x001F8638
		public static EVisualNovelTransitionType FromString(string name)
		{
			EVisualNovelTransitionType result;
			if (!EVisualNovelTransitionTypeExtensions.TryFromString(name, out result))
			{
				throw new InvalidCastException("从字符串转成枚举 EVisualNovelTransitionType 失败, 字符串: " + name);
			}
			return result;
		}

		// Token: 0x0600D88C RID: 55436 RVA: 0x001FA461 File Offset: 0x001F8661
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

		// Token: 0x0600D88D RID: 55437 RVA: 0x001FA49A File Offset: 0x001F869A
		public static string[] GetStringValues()
		{
			return new string[]
			{
				"Location",
				"Time"
			};
		}

		// Token: 0x0600D88E RID: 55438 RVA: 0x001FA4B2 File Offset: 0x001F86B2
		public static EVisualNovelTransitionType[] GetValues()
		{
			return new EVisualNovelTransitionType[]
			{
				EVisualNovelTransitionType.Location,
				EVisualNovelTransitionType.Time
			};
		}

		// Token: 0x0600D88F RID: 55439 RVA: 0x001FA4BE File Offset: 0x001F86BE
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
